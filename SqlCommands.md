# SQL Commands Used in Database Creation
---
#### 1. To create the stylist table:
>CREATE TABLE `chris_rudnicky`.`stylist` ( `id` INT NOT NULL AUTO_INCREMENT ,  `stylistName` VARCHAR(255) NOT NULL ,    PRIMARY KEY  (`id`));   
---
#### 2. To create the client table:
>CREATE TABLE `chris_rudnicky`.`client` ( `id` INT NOT NULL AUTO_INCREMENT ,  `clientName` VARCHAR(255) NOT NULL ,  `stylistId` INT NOT NULL ,    PRIMARY KEY  (`id`));
---
#### 3. To create a copy of the production code database for testing:
###### Create a new database
>CREATE DATABASE IF NOT EXISTS `chris_rudnicky_test` DEFAULT CHARSET=utf8 COLLATE utf8_general_ci;
###### Create a new client table
>CREATE TABLE `chris_rudnicky_test`.`client` (
  `id` int(11) NOT NULL,
  `clientName` varchar(255) NOT NULL,
  `stylistId` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
###### Adjust the properties of the id column so that it is now a pirmary key
>ALTER TABLE `chris_rudnicky_test`.`client` ADD PRIMARY KEY (`id`);
###### Allows the pirmary key to be autoincremented
>ALTER TABLE `chris_rudnicky_test`.`client` MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
###### Create a new stylist table
>CREATE TABLE `chris_rudnicky_test`.`stylist` (
  `id` int(11) NOT NULL,
  `stylistName` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
###### Adjust the properties of the id column so that it is now a pirmary key
>ALTER TABLE `chris_rudnicky_test`.`stylist` ADD PRIMARY KEY (`id`);
###### Allows the pirmary key to be autoincremented
>ALTER TABLE `chris_rudnicky_test`.`stylist` MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;  
---
