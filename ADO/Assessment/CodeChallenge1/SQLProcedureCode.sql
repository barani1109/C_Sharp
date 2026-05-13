CREATE DATABASE Employeemanagement;

USE Employeemanagement;


--------question1

CREATE TABLE Employee_Details
(
    Empno INT PRIMARY KEY,
    EmpName VARCHAR(50) NOT NULL,
    Empsal NUMERIC(10,2) CHECK (Empsal >= 25000),
    Emptype CHAR(1) CHECK (Emptype IN ('F','P'))
);

CREATE PROCEDURE sp_InsertEmployee
(
    @EmpName VARCHAR(50),
    @Empsal NUMERIC(10,2),
    @Emptype CHAR(1)
)
AS
BEGIN

    DECLARE @Empno INT;

    -- Generate Employee Number
    SELECT @Empno = ISNULL(MAX(Empno),1000) + 1
    FROM Employee_Details;

    -- Insert Record
    INSERT INTO Employee_Details
    VALUES(@Empno,@EmpName,@Empsal,@Emptype);

    PRINT 'Employee Inserted Successfully';

END

EXEC sp_InsertEmployee 'Rahul',30000,'F';

EXEC sp_InsertEmployee 'Amit',45000,'P';

SELECT * FROM Employee_Details;



-------question2


CREATE PROCEDURE sp_UpdateSalary
(
    @empid INT,
    @UpdatedSalary NUMERIC(10,2) OUTPUT
)
AS
BEGIN

    -- Update Salary
    UPDATE Employee_Details
    SET Empsal = Empsal + 100
    WHERE Empno = @empid

    -- Return Updated Salary
    SELECT @UpdatedSalary = Empsal
    FROM Employee_Details
    WHERE Empno = @empid

END