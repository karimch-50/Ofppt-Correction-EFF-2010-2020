DECLARE @i int, @nombre int
DECLARE @t TABLE ( a int, b int, c int)
SET @i = 1
SET @nombre = 8
WHILE (@i <= 10)
BEGIN 
      INSERT INTO @t VALUES (@nombre, @i, @i*@nombre)
      SET @i =@i + 1
END

SELECT * FROM @t
----------------------------
DECLARE @Number int, @count INT, @Result INT
SELECT @Number=4, @count=0
WHILE(@count<=10)
BEGIN
      SET @Number=@Number
      SET @Result=@Number*@count
      PRINT CONVERT(varchar(10),@Number)+'x'+CAST(@count AS VARCHAR(10))+'='+CONVERT(VARCHAR(10),@Result)
      SET @count=@count+1
END
----------------------------
DECLARE @anyNumber int, @anyString nvarchar(20) 
SET @anyNumber = 42
SELECT @anyString = CASE @anyNumber
WHEN 10 THEN 'dix' 
 WHEN 24 THEN 'vingt quatre' 
 WHEN 42 THEN 'quarante deux' 
 WHEN 68 THEN 'soixante huit'
Else 'aucun'
end
PRINT 'Le nombre est ' + @anyString 
----------------------------
SELECT TOP 5 * FROM employee 
ORDER BY sex , first_name
----------------------------
SELECT * FROM employee
WHERE birth_day LIKE '%____-02-__%'
ORDER BY birth_day 
----------------------------
ALTER TABLE employee
ADD FOREIGN KEY(branch_id)
REFERENCES branch(branch_id)
ON DELETE SET NULL;
----------------------------
ALTER TABLE employee
ADD CONSTRAINT C1
CHECK (age>20)
----------------------------
ALTER TABLE employee
ALTER COLUMN nom VARCHAR(20)
----------------------------
GO
CREATE TRIGGER trg1
ON Messagee FOR INSERT
AS
BEGIN
    DECLARE @ADR VARCHAR(30) 
    SELECT @ADR = adresseEmailExpediteur FROM INSERTED 

    IF EXISTS (SELECT * FROM INSERTED I, Groupe G, Compte C 
    WHERE G.idGroupe = C.idGroupe AND I.adresseEmailExpediteur = C.adresseEmail
    AND G.nomGroupe = 'Chef de service')
    BEGIN
        UPDATE Messagee SET Priorite = 'Eleve' WHERE adresseEmailExpediteur = @ADR
    END
END
----------------------------










