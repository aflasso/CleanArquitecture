CREATE TABLE `teamsdb`.`Teams` (
  `Id` INT NOT NULL AUTO_INCREMENT,
  `Name` VARCHAR(50) NOT NULL,
  `Coach`  VARCHAR(50) NULL,
  `Conference`  VARCHAR(20) NULL,
  PRIMARY KEY (`Id`));
  
  CREATE TABLE `teamsdb`.`TeamMembers` (
    `Id` INT NOT NULL AUTO_INCREMENT,
    `TeamId` INT NOT NULL,
    `FirstName` VARCHAR(50) NOT NULL,
    `LastName` VARCHAR(50) NOT NULL,
    `Position`  VARCHAR(20) NULL,
  PRIMARY KEY (`Id`));

ALTER TABLE `teamsdb`.`TeamMembers`
ADD FOREIGN KEY (TeamId) REFERENCES Teams(Id);