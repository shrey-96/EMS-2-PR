CREATE DATABASE EMS

go
use EMS

CREATE TABLE Demographics
(
	HCN varchar(300) PRIMARY KEY NOT NULL,
	LastName varchar(300) NOT NULL,
	FirstName varchar(300) NOT NULL,
	mInitial varchar(300) NOT NULL,
	DOB varchar(300) NOT NULL,
	sex varchar(300) NOT NULL,
	HOH_HCN varchar(300),
	addL1 varchar(300),
	addL2 varchar(300),
	city varchar(300),
	province varchar(300),
	Phone varchar(300) NOT NULL
);


CREATE TABLE Appointment
(
	AppointmentID int PRIMARY KEY,
	HCN varchar(300),
	DateOfApp DATE
);


go
-- STORED PROCEDURE: UpdateConfig
CREATE PROC CreatePatient
@HCN_param varchar(300),
@LastName_param varchar(300),
@FirstName_param varchar(300),
@mInitial_param varchar(300),
@DOB_param varchar(300) ,
@sex_param varchar(300),
@HOH_HCN_param varchar(300),
@addL1_param varchar(300),
@addL2_param varchar(300),
@city_param varchar(300),
@province_param varchar(300),
@Phone_param varchar(300)


AS
begin
INSERT INTO Demographics values
(@HCN_param, @LastName_param, @FirstName_param, @mInitial_param, @DOB_param,  
@sex_param, @HOH_HCN_param, @addL1_param, @addL2_param, @city_param, 
@province_param, @Phone_param)
end

