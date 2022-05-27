// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

FileLogger fileLogger = new FileLogger();
fileLogger.writeLog();

DataBaseLogger dataBaseLogger = new DataBaseLogger();
dataBaseLogger.writeLog();

SmsLogger smsLogger = new SmsLogger();
smsLogger.writeLog();

Console.WriteLine("--------------------------------------");

LogManager logManager = new LogManager(new FileLogger()); // Bu yöntem daha iyi
logManager.writeLog();
LogManager logManager2 = new LogManager(new SmsLogger());
logManager2.writeLog();
LogManager logManager3 = new LogManager(new DataBaseLogger());
logManager3.writeLog();

/*
Interface yani arayüzler nesneye dayalı programlamanın önemli özelliklerinden biridir. 
Sınıfların içermesi gereken metotların imzalarının yer aldığı, 
özelliklerin tanımlandığı bir taslak gibi düşünebiliriz.
*/