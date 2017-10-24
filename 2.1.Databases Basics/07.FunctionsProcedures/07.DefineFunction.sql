CREATE FUNCTION ufn_IsWordComprised (@seaOfLetters VARCHAR(50), @word VARCHAR(50))
RETURNS BIT
AS
BEGIN
	DECLARE @wordCurrentIndex INT = 1,
			@currentLetter VARCHAR(50)
	WHILE @wordCurrentIndex <= LEN(@word)
	BEGIN
		SET @currentLetter = SUBSTRING(@word, @wordCurrentIndex, 1);
		IF (@seaOfLetters NOT LIKE '%' + @currentLetter + '%')
		BEGIN
			RETURN 0;
		END
		SET @wordCurrentIndex += 1;
	END
	RETURN 1;
END