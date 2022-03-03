create database EMedic

use EMedic

drop table dAppointment
drop table pFather
drop table pResult
drop table Payment
drop table Test
drop table Patient
drop table Doctor

create table Patient(
pID int primary key NOT NULL IDENTITY(1, 1),
pName varchar(50),
pAge int,
pGender varchar(50),
pPhoneNum varchar(50),
pCNIC varchar(50),
pEmail varchar(50),
pPassword varchar(50),
pIsDeleted varchar(50) DEFAULT 'No'
);

create table pFather(
pFID int primary key NOT NULL IDENTITY(1, 1),
pFName varchar(50),
pFPhoneNum varchar(50),
pFCNIC varchar(50),
pID int,
FOREIGN KEY(pID) REFERENCES Patient(pID)
);

create table Test(
tID int primary key NOT NULL IDENTITY(1, 1),
tName varchar(50),
tPrice int, 
);

insert into Test(tName, tPrice) values('HIV', '5000')
insert into Test(tName, tPrice) values('Malaria', '500')
insert into Test(tName, tPrice) values('Lung Cancer', '10000')
insert into Test(tName, tPrice) values('Corona', '7000')
insert into Test(tName, tPrice) values('Ligma', '50000')
insert into Test(tName, tPrice) values('Hepatitis', '7500')

create table Payment(
payID int primary key NOT NULL IDENTITY(1, 1),
payStatus varchar(50) DEFAULT 'Pending', 
payDueDate varchar(50), 
tID int, 
FOREIGN KEY(tID) REFERENCES Test(tID),
pID int,
FOREIGN KEY(pID) REFERENCES Patient(pID)
);

create table pResult(
rResult varchar(50) DEFAULT 'Pending', 
payID int,
FOREIGN KEY(payID) REFERENCES Payment(payID),
tID int, 
FOREIGN KEY(tID) REFERENCES Test(tID),
pID int,
FOREIGN KEY(pID) REFERENCES Patient(pID),
);

create table Doctor(
dID int primary key NOT NULL IDENTITY(1, 1),
dName varchar(50),
dHome varchar(50),
dSpeciality varchar(50),
dSalary int,
dIsDeleted varchar(5)
);

insert into Doctor(dName, dSpeciality, dHome, dSalary, dIsDeleted) values('Mary Prendergast', 'Nephrologist','Yes', 1000, 'No')
insert into Doctor(dName, dSpeciality, dHome, dSalary, dIsDeleted) values('Robert Bright', 'Neurologist','Yes', 1500, 'No')
insert into Doctor(dName, dSpeciality, dHome, dSalary, dIsDeleted) values('Mary Kasten', 'Pediatric','No', 3500, 'No')
insert into Doctor(dName, dSpeciality, dHome, dSalary, dIsDeleted) values('Edward Lew', 'Psychiatric','No', 2500, 'No')
insert into Doctor(dName, dSpeciality, dHome, dSalary, dIsDeleted) values('Nathan Cummins', 'Cardiologist','Yes', 3000, 'No')

create table dAppointment(
aID int primary key NOT NULL IDENTITY(1, 1),
aDate varchar(50),
Payment varchar(50) Default 'Pending',
timeSlot varchar(50),
AppointmentStatus varchar(50) default 'Not Cancelled',
AppointmentPlace varchar(50),
dID int,
FOREIGN KEY(dID) REFERENCES Doctor(dID),
pID int,
FOREIGN KEY(pID) REFERENCES Patient(pID)
);

/* DONT RUN THESE QUERIES - TESTING PURPOSES ONLY */
SELECT pID, count(*) as c FROM Patient WHERE pID = 2 GROUP BY pID

SELECT Test.tName, pResult.rResult FROM pResult INNER JOIN Test ON pResult.tID = Test.tID WHERE pID='2'

SELECT pID, pPassword FROM Patient WHERE pEmail = 1

SELECT dID, dName, dSpeciality, dHome, dSalary FROM Doctor WHERE dIsDeleted!='No'