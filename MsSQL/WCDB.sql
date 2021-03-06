create procedure AddInfoToTableFromSotrudnik
	@IDE int,
	@count int,
	@Id int output
AS
BEGIN
	insert into Tabel (TheDate, FaktWorkingDay, EmployeeID) VALUES
	((DATEFROMPARTS ( 2019 , @count , 1 )),(ROUND((6*RAND()+18),0)),(SELECT Id From Employee where Employee.Id=@IDE) )
	SET @Id= @@IDENTITY
END;


DECLARE 
	@counted int = 1,
	@Ident int
while @counted<13
	Begin
		Exec AddInfoToTableFromSotrudnik 3,@counted,@Ident OUTPUT;
		Exec AddInfoToTableFromSotrudnik 4,@counted,@Ident OUTPUT;
		Exec AddInfoToTableFromSotrudnik 5,@counted,@Ident OUTPUT;
		Exec AddInfoToTableFromSotrudnik 6,@counted,@Ident OUTPUT;
		Exec AddInfoToTableFromSotrudnik 7,@counted,@Ident OUTPUT;
		Exec AddInfoToTableFromSotrudnik 8,@counted,@Ident OUTPUT;
		Exec AddInfoToTableFromSotrudnik 9,@counted,@Ident OUTPUT;
		Exec AddInfoToTableFromSotrudnik 10,@counted,@Ident OUTPUT;
		Exec AddInfoToTableFromSotrudnik 11,@counted,@Ident OUTPUT;
		Exec AddInfoToTableFromSotrudnik 12,@counted,@Ident OUTPUT;
		SET @counted=@counted+1;
	End;

insert into TypeNU VALUES
('Оклад',10,0,1),
('Премия',11,0,0),
('Отпуск',12,0,0),
('Больничный лист',13,0,0),
('Надбавка',14,0,1),
('Оклад',15,0,0),
('Подоходный налог',16,1,0),
('Военный сбор',17,2,0),
('Един.Соц.Взнос',18,3,0),
('Выплата ЗП',19,4,0)

create procedure AddInfoSotrudnikProfit
	@IDE int,
	@IDTNU int,
	@SUM float,
	@Id int output
AS
BEGIN
	insert into SotrudnikProfit (SumPayment, EmployeeID, TypeNUID) Values
	(@SUM,(Select Id From Employee where Employee.Id=@IDE),(Select Id From TypeNU Where TypeNU.Id=@IDTNU))
	SET @Id=@@IDENTITY
END;

declare
	@randi float,
	@prem float,
	@iden int
SET @randi=(6000*RAND()+8000)
SET @prem=(900*RAND()+1500)
exec AddInfoSotrudnikProfit 3,6,@randi,@iden OUTPUT
SET @randi=(6000*RAND()+8000)
SET @prem=(900*RAND()+1500)
exec AddInfoSotrudnikProfit 4,6,@randi,@iden OUTPUT
SET @randi=(6000*RAND()+8000)
SET @prem=(900*RAND()+1500)
exec AddInfoSotrudnikProfit 5,6,@randi,@iden OUTPUT
SET @randi=(6000*RAND()+8000)
SET @prem=(900*RAND()+1500)
exec AddInfoSotrudnikProfit 6,6,@randi,@iden OUTPUT
SET @randi=(6000*RAND()+8000)
SET @prem=(900*RAND()+1500)
exec AddInfoSotrudnikProfit 7,6,@randi,@iden OUTPUT
SET @randi=(6000*RAND()+8000)
SET @prem=(900*RAND()+1500)
exec AddInfoSotrudnikProfit 8,6,@randi,@iden OUTPUT
SET @randi=(6000*RAND()+8000)
SET @prem=(900*RAND()+1500)
exec AddInfoSotrudnikProfit 9,6,@randi,@iden OUTPUT
SET @randi=(6000*RAND()+8000)
SET @prem=(900*RAND()+1500)
exec AddInfoSotrudnikProfit 10,6,@randi,@iden OUTPUT
SET @randi=(6000*RAND()+8000)
SET @prem=(900*RAND()+1500)
exec AddInfoSotrudnikProfit 11,6,@randi,@iden OUTPUT
SET @randi=(6000*RAND()+8000)
SET @prem=(900*RAND()+1500)
exec AddInfoSotrudnikProfit 12,6,@randi,@iden OUTPUT

SET @randi=(6000*RAND()+8000)
SET @prem=(900*RAND()+1500)
exec AddInfoSotrudnikProfit 3,1,@randi,@iden OUTPUT
SET @randi=(6000*RAND()+8000)
SET @prem=(900*RAND()+1500)
exec AddInfoSotrudnikProfit 3,2,@prem,@iden OUTPUT
SET @randi=(6000*RAND()+8000)
SET @prem=(900*RAND()+1500)
exec AddInfoSotrudnikProfit 4,1,@randi,@iden OUTPUT
SET @randi=(6000*RAND()+8000)
SET @prem=(900*RAND()+1500)
exec AddInfoSotrudnikProfit 4,2,@prem,@iden OUTPUT
SET @randi=(6000*RAND()+8000)
SET @prem=(900*RAND()+1500)
exec AddInfoSotrudnikProfit 5,1,@randi,@iden OUTPUT
SET @randi=(6000*RAND()+8000)
SET @prem=(900*RAND()+1500)
exec AddInfoSotrudnikProfit 5,2,@prem,@iden OUTPUT
SET @randi=(6000*RAND()+8000)
SET @prem=(900*RAND()+1500)
exec AddInfoSotrudnikProfit 6,1,@randi,@iden OUTPUT
SET @randi=(6000*RAND()+8000)
SET @prem=(900*RAND()+1500)
exec AddInfoSotrudnikProfit 6,2,@prem,@iden OUTPUT
SET @randi=(6000*RAND()+8000)
SET @prem=(900*RAND()+1500)
exec AddInfoSotrudnikProfit 7,1,@randi,@iden OUTPUT
SET @randi=(6000*RAND()+8000)
SET @prem=(900*RAND()+1500)
exec AddInfoSotrudnikProfit 7,2,@prem,@iden OUTPUT
SET @randi=(6000*RAND()+8000)
SET @prem=(900*RAND()+1500)
exec AddInfoSotrudnikProfit 8,1,@randi,@iden OUTPUT
SET @randi=(6000*RAND()+8000)
SET @prem=(900*RAND()+1500)
exec AddInfoSotrudnikProfit 8,2,@prem,@iden OUTPUT
SET @randi=(6000*RAND()+8000)
SET @prem=(900*RAND()+1500)
exec AddInfoSotrudnikProfit 9,1,@randi,@iden OUTPUT
SET @randi=(6000*RAND()+8000)
SET @prem=(900*RAND()+1500)
exec AddInfoSotrudnikProfit 9,2,@prem,@iden OUTPUT
SET @randi=(6000*RAND()+8000)
SET @prem=(900*RAND()+1500)
exec AddInfoSotrudnikProfit 10,1,@randi,@iden OUTPUT
SET @randi=(6000*RAND()+8000)
SET @prem=(900*RAND()+1500)
exec AddInfoSotrudnikProfit 10,2,@prem,@iden OUTPUT
SET @randi=(6000*RAND()+8000)
SET @prem=(900*RAND()+1500)
exec AddInfoSotrudnikProfit 11,1,@randi,@iden OUTPUT
SET @randi=(6000*RAND()+8000)
SET @prem=(900*RAND()+1500)
exec AddInfoSotrudnikProfit 11,2,@prem,@iden OUTPUT
SET @randi=(6000*RAND()+8000)
SET @prem=(900*RAND()+1500)
exec AddInfoSotrudnikProfit 12,1,@randi,@iden OUTPUT
SET @randi=(6000*RAND()+8000)
SET @prem=(900*RAND()+1500)
exec AddInfoSotrudnikProfit 12,2,@prem,@iden OUTPUT




create function FullNameSotrudnik(@x int)
RETURNS NVARCHAR(100)
AS
BEGIN
	DECLARE @imya nvarchar(100);
	SELECT @imya= FirstName+' '+LastName+' '+SecondName from Employee where Employee.Id=@x;
	return @imya;
END;

create function CalcPN(@x float)
RETURNS FLOAT
AS
BEGIN
	DECLARE 
		@calc float=((@x) * 0.18);
		return @calc;
END;

create function CalcVZ (@x float)
RETURNS FLOAT
AS
BEGIN
	DECLARE 
		@calc float=((@x) * 0.015);
		return @calc;
END;

create function CalcESV (@x float)
RETURNS FLOAT
AS
BEGIN
	DECLARE 
		@calc float=((@x) * 0.22);
		return @calc;
END;

alter procedure CalcTax
	@Ide int,
	@Dt date,
	@Dt2 date,
	@Id int Output
AS
Begin
	DECLARE @sum float,
			@sum1 float,
			@sum2 float,
			@sum3 float;			
	SELECT @sum=sum(SumPayment) from SotrudnikProfit sp where 
((select Payment from TypeNU typ where typ.Id=sp.TypeNUID)=0 AND sp.EmployeeID=@Ide)
AND sp.DateOfStartDo=@Dt2
	SET @sum1=dbo.CalcPN(@sum);
	SET @sum2=dbo.CalcESV(@sum);
	SET @sum3=dbo.CalcVZ(@sum);
	insert into Paylist VALUES
	( @sum1,@Dt,(MONTH(@Dt)),
	  (SELECT FaktWorkingDay FROM Tabel t where t.EmployeeID=@Ide AND t.TheDate=@Dt),
	  (Select Id From Employee e where e.Id=@Ide),
	  7
	)
	insert into Paylist VALUES
	( @sum2,@Dt,(MONTH(@Dt)),
	  (SELECT FaktWorkingDay FROM Tabel t where t.EmployeeID=@Ide AND t.TheDate=@Dt),
	  (Select Id From Employee e where e.Id=@Ide),
	  9
	)
	insert into Paylist VALUES
	( @sum3,@Dt,(MONTH(@Dt)),
	  (SELECT FaktWorkingDay FROM Tabel t where t.EmployeeID=5 AND t.TheDate=@Dt),
	  (Select Id From Employee e where e.Id=5),
	  8
	)
	SET @Id=@@IDENTITY
	return @sum;
End;


Declare
			@Id int;
exec CalcTax 3,'2019-04-01', '2020-04-01', @Id output
exec CalcTax 4,'2019-04-01', '2020-04-01', @Id output
exec CalcTax 5,'2019-04-01', '2020-04-01', @Id output
exec CalcTax 6,'2019-04-01', '2020-04-01', @Id output
exec CalcTax 7,'2019-04-01', '2020-04-01', @Id output
exec CalcTax 8,'2019-04-01', '2020-04-01', @Id output
exec CalcTax 9,'2019-04-01', '2020-04-01', @Id output
exec CalcTax 10,'2019-04-01', '2020-04-01', @Id output
exec CalcTax 11,'2019-04-01', '2020-04-01', @Id output
exec CalcTax 12,'2019-04-01', '2020-04-01', @Id output



select sum(SumPayment) from SotrudnikProfit sp where 
((select Payment from TypeNU typ where typ.Id=sp.TypeNUID)=0 AND sp.EmployeeID=5) AND sp.DateOfStartDo='2020-04-01'

--29. Создать процедуру расчета ЗП по сотруднику CalcSalary.
--	Процедура принимает целое число (первичный ключ сотрудника) и дату.
--	По указазанному сотруднику необходимо получить все Начисления (таблица SotrudnikProfit).
--	   Если начисление зависит от отработ. времени, то необходимо:
--		- получить сумму по начислен. (Сумма начисл.)
--		- получить по указ. дате норму из таблицы Graph (Норма)
--		- получить по указ. дате и сотруднику факт. отраб. время из таблицы Tabel (Факт.отраб.дни)
--		- посчитать сумму по формуле : ((Сумма начисл.)/(Норма))* (Факт.отраб.дни)
--	   Если начисление не зависит, то расчитываемая сумма равна значению из таблицы SotrudnikProfit по указ. сотруднику (поле Сумма оплаты).

--	После расчета Начисления - занести данные в таблицу Paylist

--	Далее необходимо вызывать процедуру из п.28, которая посчитает налоги по сотруднику
alter proc CalcSalary
	@IdCus int,
	@Dat date
AS
BEGIN
	 DECLARE 
			@sumP float,
			@NormWD int,
			@FactWD int,
			@totalSum float;DECLARE zp_cursor CURSOR FOR
		SELECT sp.SumPayment, g.NormOfWorkingDay, t.FaktWorkingDay, ((sp.SumPayment)/(g.NormOfWorkingDay))*(t.FaktWorkingDay)
		FROM SotrudnikProfit sp
		LEFT JOIN Graph g ON g.TheDate=sp.DateOfStartDo
		LEFT JOIN Tabel t ON t.EmployeeID=@IdCus
		WHERE sp.EmployeeID=@IdCus
		Open zp_cursor
		FETCH NEXT FROM zp_cursor INTO @sumP, @NormWD, @FactWD, @totalSum
		IF @@FETCH_STATUS!=0
			Print 'Начислений нет'
		WHILE @@FETCH_STATUS = 0
		BEGIN
			INSERT INTO Paylist (Id, WorkingDay, DateOfChekPayments, DateOfMouth, EmployeeID, FaktPaymets)Values
			(
				@@IDENTITY,@FactWD, @Dat, MONTH(@Dat), @IdCus, @totalSum
			)
			FETCH NEXT FROM zp_cursor INTO @sumP, @NormWD, @FactWD, @totalSum
		END;
CLOSE zp_cursor
DEALLOCATE zp_cursor
ENd;

--30. Создать Процедуру CreateSumForPay, которая  принимает целое число (первичный ключ сотрудника) и дату.
--	ПРоцедура, должна получить:
--	- сумму начисления по ЗП (!!! только начисления - оклад, премия, и т.п.) за указанный месяц и по указанному сотруднику
--	- сумму удержаний по ЗП (!!! только удержания - налоги - Подох. налог и Военный сбор.) за указанный месяц и по указанному сотруднику.
--		Един.Соц.Взнос в расчет не включаем, т.к. этот налог платит собственник предприятия
--	- Получить разницу из выше посчитанных сумм. Если сумма больше нуля, то занести данные в таблицу Paylist как сумма выплаты.
alter proc CreateSumForPay
	@Ide int,
	@D date,
	@Id int output
AS
BEGIN
	DECLARE @sumNZP float, @sumUZP float, @totalsum float;
	SELECT @sumNZP=sum(SumPayment) From SotrudnikProfit sp where sp.EmployeeID=@Ide AND sp.TypeNUID<7 AND DateOfStartDo=@D

	SELECT @sumUZP=sum(SumPayment) From SotrudnikProfit sp where sp.EmployeeID=@Ide AND sp.TypeNUID>6 AND DateOfStartDo=@D

	SET @totalsum=@sumNZP-@sumUZP;
	IF @totalsum>0
	BEGIN
		insert into Paylist Values
		(
			@totalsum, GETDATE(), MONTH(@D),(SELECT FaktWorkingDay FROM Tabel where Tabel.EmployeeID=@Ide),@Ide,1
		)
		SET @Id=@@IDENTITY;
	END;
END;
DECLARE @Id int;
exec CreateSumForPay 3,'2020-04-01',@Id output
exec CreateSumForPay 12,'2020-04-01',@Id output;
exec CreateSumForPay 4,'2020-04-01',@Id output;
exec CreateSumForPay 5,'2020-04-01',@Id output;
exec CreateSumForPay 6,'2020-04-01',@Id output;
exec CreateSumForPay 7,'2020-04-01',@Id output;
exec CreateSumForPay 8,'2020-04-01',@Id output;
exec CreateSumForPay 9,'2020-04-01',@Id output;
exec CreateSumForPay 10,'2020-04-01',@Id output;
exec CreateSumForPay 11,'2020-04-01',@Id output;

--31. Создать функцию GetCalcedWageForMonth, которая принимает  дату и возвращает таблицу следующего вида:
--	Сотрудник ФИО
--	Должность 
--	Подразделение
--	Сумма нач. ЗП
--	Сумма уд. Налогов
--	Сумма выплаты
--	Сумма на руки
	
--	Данные необходимо получить из таблиц Sotrudnik, Position, Department, Paylist и процедуры CreateSumForPay
--	Данные необходимо вывести по всем сотрудникам.

CREATE FUNCTION GetCalcedWageForMonth(@DA datetime, @IDSH int)
RETURNS @result table
   (
      Id int NOT NULL,
	  Dolgnost nvarchar(100) not null,
      FIO nvarchar(200) NOT NULL,
      Department nvarchar(100) NOT NULL,
      SumStartZP float NOT NULL,
      SumUdNalog float NOT NULL,
      SumForPayment float NOT NULL,
      SumForHands float NOT NULL,
      PRIMARY KEY (Id)
   )
AS
   BEGIN
   DECLARE @FIO nvarchar(200),
			@Dolg nvarchar(100),
			@Dep nvarchar(100),
			@SSZP float,
			@SUN float,
			@SFP float,
			@SFH float
		SELECT @SUN=sum(SumPayment) From SotrudnikProfit sp where sp.EmployeeID=@IDSH AND sp.TypeNUID>6 AND DateOfStartDo=@DA;
		SELECT @FIO=FirstName+' '+LastName+' '+SecondName from Employee e where e.Id =@IDSH;
		SELECT @Dolg=PositionName from Position p where p.Id=@IDSH; 
		SELECT @Dep=DepartmentName from Department d where d.Id=@IDSH;
		SELECT @SSZP=sum(SumPayment) From SotrudnikProfit sp where sp.EmployeeID=@IDSH AND sp.TypeNUID<7 AND DateOfStartDo=@DA;
		SELECT @SFH=FaktPaymets from Paylist pay where pay.DateOfMouth=@IDSH;
		SELECT @SFP=SumPayment from SotrudnikProfit sp where sp.EmployeeID=@IDSH;  
      INSERT INTO @result values
      (
         @@IDENTITY,@Dolg,@FIO,@Dep,@SSZP,@SUN,@SFP,@SFH
      )
         
      RETURN;
   END;