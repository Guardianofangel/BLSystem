--DROP TABLE Bog;
--DROP TABLE BogHold;
--DROP TABLE UnderviserBog;
CREATE TABLE Bog( Bog_id int NOT NULL PRIMARY KEY,Title VARCHAR (30) NOT NULL,Forfatter VARCHAR(30) NOT NULL, Udgivelsesår INT NOT NULL, ISBN FLOAT NOT NULL, Billede VARCHAR (256) NOT NULL); 
CREATE TABLE UnderviserBog(UnderviserBog_id int NOT NULL PRIMARY KEY,Underviser_id int NOT NULL FOREIGN KEY (Underviser_id) REFERENCES Underviser (Underviser_id), Bog_id int NOT NULL FOREIGN KEY (Bog_id) REFERENCES Bog (Bog_id));
--CREATE TABLE UnderviserHold( UnderviserHold_id int NOT NULL PRIMARY KEY, Underviser_id int NOT NULL FOREIGN KEY (Underviser_id) REFERENCES Underviser (Underviser_id), Hold_id int NOT NULL FOREIGN KEY (Hold_id) REFERENCES Hold (Hold_id));
CREATE TABLE BogHold (BogHold_id int NOT NULL PRIMARY KEY, Bog_id int NOT NULL FOREIGN KEY (Bog_id) REFERENCES Bog (Bog_id), Hold_id int NOT NULL FOREIGN KEY (Hold_id) REFERENCES Hold (Hold_id));
