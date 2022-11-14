
-- DDL (database design)
DROP TABLE IF EXISTS [appointments];
DROP TABLE IF EXISTS [patients];
DROP TABLE IF EXISTS [schedules];
DROP TABLE IF EXISTS [times];
DROP TABLE IF EXISTS [days];


CREATE TABLE [days](
  [id] INTEGER PRIMARY KEY, 
  [name] TEXT,
  UNIQUE([name])) WITHOUT ROWID;

CREATE TABLE [times](
  [id] INTEGER PRIMARY KEY, 
  [description] TEXT,
  UNIQUE([description])) WITHOUT ROWID;
  
CREATE TABLE [schedules](
  [day_id] INTEGER REFERENCES [days]([id]),
  [time_id] INTEGER REFERENCES [times]([id]),
  PRIMARY KEY([day_id], [time_id])) WITHOUT ROWID;

CREATE TABLE [patients](
  [id] INTEGER PRIMARY KEY, 
  [first_name] TEXT,
  [last_name] TEXT) WITHOUT ROWID;

CREATE TABLE [appointments](
  [patient_id] INTEGER PRIMARY KEY REFERENCES [patients]([id]),
  [day_id] INTEGER REFERENCES [days]([id]),
  [time_id] INTEGER REFERENCES [times]([id]),
  FOREIGN KEY([day_id], [time_id])
  REFERENCES [schedules]([day_id], [time_id])) WITHOUT ROWID;
  

-- SQL (initial data)

INSERT INTO days(id, name) VALUES(0, 'Lunes');
INSERT INTO days(id, name) VALUES(1, 'Martes');
INSERT INTO days(id, name) VALUES(2, 'Miercoles');
INSERT INTO days(id, name) VALUES(3, 'Jueves');
INSERT INTO days(id, name) VALUES(4, 'Viernes');
INSERT INTO days(id, name) VALUES(5, 'Sabado');
INSERT INTO days(id, name) VALUES(6, 'Domingo');

INSERT INTO times(id, description) VALUES(0, '09:00 a.m.');
INSERT INTO times(id, description) VALUES(1, '09:30 a.m.');
INSERT INTO times(id, description) VALUES(2, '10:00 a.m.');
INSERT INTO times(id, description) VALUES(3, '10:30 a.m.');
INSERT INTO times(id, description) VALUES(4, '11:00 a.m.');
INSERT INTO times(id, description) VALUES(5, '11:30 a.m.');
INSERT INTO times(id, description) VALUES(6, '12:00 p.m.');
INSERT INTO times(id, description) VALUES(7, '12:30 p.m.');
INSERT INTO times(id, description) VALUES(8, '01:00 p.m.');
INSERT INTO times(id, description) VALUES(9, '01:30 p.m.');
INSERT INTO times(id, description) VALUES(10, '02:00 p.m.');
INSERT INTO times(id, description) VALUES(11, '05:00 p.m.');
INSERT INTO times(id, description) VALUES(12, '05:30 p.m.');
INSERT INTO times(id, description) VALUES(13, '06:00 p.m.');
INSERT INTO times(id, description) VALUES(14, '06:30 p.m.');
INSERT INTO times(id, description) VALUES(15, '07:00 p.m.');
INSERT INTO times(id, description) VALUES(16, '07:30 p.m.');
INSERT INTO times(id, description) VALUES(17, '08:00 p.m.');

INSERT INTO schedules(day_id, time_id) VALUES(0, 0);
INSERT INTO schedules(day_id, time_id) VALUES(0, 1);
INSERT INTO schedules(day_id, time_id) VALUES(0, 2);
INSERT INTO schedules(day_id, time_id) VALUES(0, 3);
INSERT INTO schedules(day_id, time_id) VALUES(0, 4);
INSERT INTO schedules(day_id, time_id) VALUES(0, 5);
INSERT INTO schedules(day_id, time_id) VALUES(0, 6);
INSERT INTO schedules(day_id, time_id) VALUES(0, 7);
INSERT INTO schedules(day_id, time_id) VALUES(0, 8);
INSERT INTO schedules(day_id, time_id) VALUES(0, 9);
INSERT INTO schedules(day_id, time_id) VALUES(0, 10);
INSERT INTO schedules(day_id, time_id) VALUES(1, 11);
INSERT INTO schedules(day_id, time_id) VALUES(1, 12);
INSERT INTO schedules(day_id, time_id) VALUES(1, 13);
INSERT INTO schedules(day_id, time_id) VALUES(1, 14);
INSERT INTO schedules(day_id, time_id) VALUES(1, 15);
INSERT INTO schedules(day_id, time_id) VALUES(1, 16);
INSERT INTO schedules(day_id, time_id) VALUES(1, 17);
INSERT INTO schedules(day_id, time_id) VALUES(2, 0);
INSERT INTO schedules(day_id, time_id) VALUES(2, 1);
INSERT INTO schedules(day_id, time_id) VALUES(2, 2);
INSERT INTO schedules(day_id, time_id) VALUES(2, 3);
INSERT INTO schedules(day_id, time_id) VALUES(2, 4);
INSERT INTO schedules(day_id, time_id) VALUES(2, 5);
INSERT INTO schedules(day_id, time_id) VALUES(2, 6);
INSERT INTO schedules(day_id, time_id) VALUES(2, 7);
INSERT INTO schedules(day_id, time_id) VALUES(2, 8);
INSERT INTO schedules(day_id, time_id) VALUES(2, 9);
INSERT INTO schedules(day_id, time_id) VALUES(2, 10);
INSERT INTO schedules(day_id, time_id) VALUES(2, 11);
INSERT INTO schedules(day_id, time_id) VALUES(2, 12);
INSERT INTO schedules(day_id, time_id) VALUES(2, 13);
INSERT INTO schedules(day_id, time_id) VALUES(2, 14);
INSERT INTO schedules(day_id, time_id) VALUES(2, 15);
INSERT INTO schedules(day_id, time_id) VALUES(2, 16);
INSERT INTO schedules(day_id, time_id) VALUES(2, 17);
INSERT INTO schedules(day_id, time_id) VALUES(3, 0);
INSERT INTO schedules(day_id, time_id) VALUES(3, 1);
INSERT INTO schedules(day_id, time_id) VALUES(3, 2);
INSERT INTO schedules(day_id, time_id) VALUES(3, 3);
INSERT INTO schedules(day_id, time_id) VALUES(3, 4);
INSERT INTO schedules(day_id, time_id) VALUES(3, 5);
INSERT INTO schedules(day_id, time_id) VALUES(3, 6);
INSERT INTO schedules(day_id, time_id) VALUES(3, 7);
INSERT INTO schedules(day_id, time_id) VALUES(3, 8);
INSERT INTO schedules(day_id, time_id) VALUES(3, 9);
INSERT INTO schedules(day_id, time_id) VALUES(3, 10);
INSERT INTO schedules(day_id, time_id) VALUES(4, 11);
INSERT INTO schedules(day_id, time_id) VALUES(4, 12);
INSERT INTO schedules(day_id, time_id) VALUES(4, 13);
INSERT INTO schedules(day_id, time_id) VALUES(4, 14);
INSERT INTO schedules(day_id, time_id) VALUES(4, 15);
INSERT INTO schedules(day_id, time_id) VALUES(4, 16);
INSERT INTO schedules(day_id, time_id) VALUES(4, 17);
INSERT INTO schedules(day_id, time_id) VALUES(5, 2);
INSERT INTO schedules(day_id, time_id) VALUES(5, 3);
INSERT INTO schedules(day_id, time_id) VALUES(5, 4);
INSERT INTO schedules(day_id, time_id) VALUES(5, 5);
INSERT INTO schedules(day_id, time_id) VALUES(5, 6);
INSERT INTO schedules(day_id, time_id) VALUES(5, 7);
INSERT INTO schedules(day_id, time_id) VALUES(5, 8);

INSERT INTO patients(id, first_name, last_name) VALUES(689155, 'Xavier', 'Quintas');
INSERT INTO patients(id, first_name, last_name) VALUES(917169, 'Jaume', 'Alguacil');
INSERT INTO patients(id, first_name, last_name) VALUES(147222, 'Jose', 'Maldonado');
INSERT INTO patients(id, first_name, last_name) VALUES(387368, 'Rafael', 'Caballero');
INSERT INTO patients(id, first_name, last_name) VALUES(876855, 'Maria', 'Ramos');
INSERT INTO patients(id, first_name, last_name) VALUES(736932, 'Francisca', 'Jurado');
INSERT INTO patients(id, first_name, last_name) VALUES(502676, 'Luis', 'Ros');
INSERT INTO patients(id, first_name, last_name) VALUES(186080, 'Antonio', 'Vargas');
INSERT INTO patients(id, first_name, last_name) VALUES(832366, 'Javier', 'Esteban');
INSERT INTO patients(id, first_name, last_name) VALUES(379061, 'Marc', 'Arroyo');
INSERT INTO patients(id, first_name, last_name) VALUES(567213, 'Jesus', 'Bermudez');
INSERT INTO patients(id, first_name, last_name) VALUES(183757, 'Ruben', 'Escribano');
INSERT INTO patients(id, first_name, last_name) VALUES(676399, 'Diego', 'Cardona');
INSERT INTO patients(id, first_name, last_name) VALUES(376270, 'Angela', 'Iglesias');
INSERT INTO patients(id, first_name, last_name) VALUES(980040, 'Francisco', 'Montiel');
INSERT INTO patients(id, first_name, last_name) VALUES(873028, 'Silvia', 'Huerta');
INSERT INTO patients(id, first_name, last_name) VALUES(358176, 'Ander', 'Correa');
INSERT INTO patients(id, first_name, last_name) VALUES(490372, 'Manuela', 'Hurtado');
INSERT INTO patients(id, first_name, last_name) VALUES(503671, 'Laia', 'Garcia');
INSERT INTO patients(id, first_name, last_name) VALUES(406268, 'Manuel', 'Ferrer');
INSERT INTO patients(id, first_name, last_name) VALUES(669193, 'Jordi', 'Suarez');
INSERT INTO patients(id, first_name, last_name) VALUES(196874, 'Miquel', 'Cordon');
INSERT INTO patients(id, first_name, last_name) VALUES(470362, 'Oscar', 'Torrente');
INSERT INTO patients(id, first_name, last_name) VALUES(132402, 'Anna', 'Corona');
INSERT INTO patients(id, first_name, last_name) VALUES(529698, 'Julian', 'Ruiz');
INSERT INTO patients(id, first_name, last_name) VALUES(951866, 'Isabel', 'Martinez');
INSERT INTO patients(id, first_name, last_name) VALUES(135377, 'Adrian', 'Ariza');
INSERT INTO patients(id, first_name, last_name) VALUES(701119, 'Sonia', 'Morillas');
INSERT INTO patients(id, first_name, last_name) VALUES(873687, 'Cinta', 'Villa');
INSERT INTO patients(id, first_name, last_name) VALUES(742623, 'Ainhoa', 'Aznar');
INSERT INTO patients(id, first_name, last_name) VALUES(293048, 'Carlos', 'Moreno');
INSERT INTO patients(id, first_name, last_name) VALUES(589509, 'Pablo', 'Roman');
INSERT INTO patients(id, first_name, last_name) VALUES(636692, 'Victor', 'Pulido');
INSERT INTO patients(id, first_name, last_name) VALUES(702720, 'Laura', 'Romero');
INSERT INTO patients(id, first_name, last_name) VALUES(670445, 'Ignacio', 'Diaz');
INSERT INTO patients(id, first_name, last_name) VALUES(824685, 'Dolores', 'Gomez');
INSERT INTO patients(id, first_name, last_name) VALUES(293204, 'Fernando', 'Diop');
INSERT INTO patients(id, first_name, last_name) VALUES(947434, 'Daniel', 'Rodriguez');
INSERT INTO patients(id, first_name, last_name) VALUES(397081, 'Angeles', 'Bosch');
INSERT INTO patients(id, first_name, last_name) VALUES(149451, 'Marta', 'Sanchez');
INSERT INTO patients(id, first_name, last_name) VALUES(899160, 'Pilar', 'Ferre');
INSERT INTO patients(id, first_name, last_name) VALUES(791174, 'Carmen', 'Serrano');
INSERT INTO patients(id, first_name, last_name) VALUES(274110, 'Luisa', 'Aguilar');
INSERT INTO patients(id, first_name, last_name) VALUES(285327, 'Rosario', 'Cortes');
INSERT INTO patients(id, first_name, last_name) VALUES(278142, 'Rosa', 'Palomo');
INSERT INTO patients(id, first_name, last_name) VALUES(706818, 'Juan', 'Calvo');
INSERT INTO patients(id, first_name, last_name) VALUES(153152, 'Elena', 'Linares');
INSERT INTO patients(id, first_name, last_name) VALUES(745831, 'Ivan', 'Osuna');
INSERT INTO patients(id, first_name, last_name) VALUES(773141, 'Ricardo', 'Segovia');
INSERT INTO patients(id, first_name, last_name) VALUES(422086, 'Irene', 'Perez');

INSERT INTO appointments(patient_id, day_id, time_id) VALUES(689155, 0, 0);
INSERT INTO appointments(patient_id, day_id, time_id) VALUES(917169, 3, 7);
INSERT INTO appointments(patient_id, day_id, time_id) VALUES(147222, 1, 17);
INSERT INTO appointments(patient_id, day_id, time_id) VALUES(387368, 4, 12);
INSERT INTO appointments(patient_id, day_id, time_id) VALUES(876855, 2, 1);
INSERT INTO appointments(patient_id, day_id, time_id) VALUES(736932, 4, 14);
INSERT INTO appointments(patient_id, day_id, time_id) VALUES(502676, 0, 1);
INSERT INTO appointments(patient_id, day_id, time_id) VALUES(186080, 0, 2);
INSERT INTO appointments(patient_id, day_id, time_id) VALUES(832366, 3, 2);
INSERT INTO appointments(patient_id, day_id, time_id) VALUES(379061, 3, 3);
INSERT INTO appointments(patient_id, day_id, time_id) VALUES(567213, 0, 8);
INSERT INTO appointments(patient_id, day_id, time_id) VALUES(183757, 4, 13);
INSERT INTO appointments(patient_id, day_id, time_id) VALUES(676399, 2, 3);
INSERT INTO appointments(patient_id, day_id, time_id) VALUES(376270, 2, 4);
INSERT INTO appointments(patient_id, day_id, time_id) VALUES(873028, 0, 3);
INSERT INTO appointments(patient_id, day_id, time_id) VALUES(490372, 0, 9);
INSERT INTO appointments(patient_id, day_id, time_id) VALUES(503671, 0, 10);
INSERT INTO appointments(patient_id, day_id, time_id) VALUES(669193, 2, 17);
INSERT INTO appointments(patient_id, day_id, time_id) VALUES(196874, 4, 16);
INSERT INTO appointments(patient_id, day_id, time_id) VALUES(470362, 0, 7);
INSERT INTO appointments(patient_id, day_id, time_id) VALUES(132402, 0, 6);
INSERT INTO appointments(patient_id, day_id, time_id) VALUES(529698, 5, 2);
INSERT INTO appointments(patient_id, day_id, time_id) VALUES(135377, 0, 4);
INSERT INTO appointments(patient_id, day_id, time_id) VALUES(701119, 0, 5);
INSERT INTO appointments(patient_id, day_id, time_id) VALUES(589509, 1, 14);
INSERT INTO appointments(patient_id, day_id, time_id) VALUES(636692, 1, 15);
INSERT INTO appointments(patient_id, day_id, time_id) VALUES(670445, 3, 10);
INSERT INTO appointments(patient_id, day_id, time_id) VALUES(824685, 4, 11);
INSERT INTO appointments(patient_id, day_id, time_id) VALUES(947434, 1, 11);
INSERT INTO appointments(patient_id, day_id, time_id) VALUES(397081, 1, 12);
INSERT INTO appointments(patient_id, day_id, time_id) VALUES(149451, 1, 13);
INSERT INTO appointments(patient_id, day_id, time_id) VALUES(791174, 5, 4);
INSERT INTO appointments(patient_id, day_id, time_id) VALUES(285327, 2, 7);
INSERT INTO appointments(patient_id, day_id, time_id) VALUES(278142, 2, 8);
INSERT INTO appointments(patient_id, day_id, time_id) VALUES(706818, 2, 9);
INSERT INTO appointments(patient_id, day_id, time_id) VALUES(153152, 5, 6);
INSERT INTO appointments(patient_id, day_id, time_id) VALUES(745831, 5, 7);

-- SQL (test queries)

SELECT * FROM days;
SELECT name FROM days;
SELECT name, id FROM days;
SELECT * FROM days ORDER BY name;
SELECT * FROM days ORDER BY name ASC;
SELECT * FROM days ORDER BY name DESC;

SELECT * FROM days WHERE id = 3;
SELECT * FROM days WHERE id >= 3 AND id <= 5;
SELECT * FROM days WHERE id >= 3 AND id <= 5 ORDER BY name;
SELECT * FROM days WHERE id IN (3, 5);

SELECT * FROM days WHERE name = 'lunes';
SELECT * FROM days WHERE name = 'Lunes';
SELECT * FROM days WHERE name LIKE 'lunes';
SELECT * FROM days WHERE name LIKE 'm%';
SELECT * FROM days WHERE name LIKE '%s';
SELECT * FROM days WHERE name LIKE '%m%';

SELECT * FROM days;
SELECT * FROM times;
SELECT * FROM days CROSS JOIN times;

SELECT * FROM days;
SELECT * FROM schedules;

SELECT *
FROM days d
CROSS JOIN schedules s
WHERE d.id = s.day_id;

SELECT *
FROM days d
INNER JOIN schedules s ON(d.id = s.day_id);

SELECT d.name, t.description
FROM days d
INNER JOIN schedules s ON(d.id = s.day_id)
INNER JOIN times t ON (t.id = s.time_id);

SELECT COUNT(*) AS qty FROM patients;
SELECT MAX(id) FROM patients;
SELECT MIN(id) FROM patients;
SELECT AVG(id) FROM patients;
SELECT SUM(id) FROM patients;


-- ************************************************
-- DENTAL CARE APPLICATION
-- ************************************************

-- CITAS POR PACIENTE
SELECT p.last_name||', '||p.first_name AS patient_full_name,
       d.name AS day_name,
       t.description AS time_description
FROM appointments a
INNER JOIN patients p ON (a.patient_id = p.id)
INNER JOIN days d ON (a.day_id = d.id)
INNER JOIN times t ON (a.time_id = t.id)
ORDER BY patient_full_name;

-- CITAS POR DIA
SELECT DISTINCT a.day_id, d.name
FROM appointments a
INNER JOIN days d ON (a.day_id = d.id)
ORDER BY a.day_id;

SELECT t.description AS time_description, p.last_name||', '||p.first_name AS patient_full_name
FROM appointments a
INNER JOIN patients p ON (a.patient_id = p.id)
INNER JOIN times t ON (a.time_id = t.id)
WHERE day_id = 0
ORDER BY t.id;

-- AGENDAR CITAS

-- lista de pacientes disponibles
SELECT id, p.last_name||', '||p.first_name AS full_name
FROM patients p
WHERE p.id NOT IN(SELECT patient_id FROM appointments)
ORDER BY full_name;

-- lista de dias con horario disponible
SELECT *
FROM days
WHERE id IN (SELECT DISTINCT day_id
             FROM schedules
             WHERE (day_id, time_id) NOT IN (SELECT day_id, time_id
                                              FROM appointments));

SELECT DISTINCT d.*
FROM schedules s
INNER JOIN days d ON (s.day_id = d.id) 
WHERE (day_id, time_id) NOT IN (SELECT day_id, time_id
                                FROM appointments);

-- lista de horas disponibles según el día seleccionado
SELECT t.*
FROM schedules s
INNER JOIN times t ON (s.time_id = t.id) 
WHERE (day_id, time_id) NOT IN (SELECT day_id, time_id
                                FROM appointments)
       AND day_id = 3
ORDER BY t.id;

-- generar cita
INSERT INTO appointments(patient_id, day_id, time_id) VALUES(0,0,0);

-- CANCELAR CITAS

SELECT id, p.last_name||', '||p.first_name AS full_name
FROM patients p
WHERE p.id IN(SELECT patient_id FROM appointments)
ORDER BY full_name;

DELETE FROM appointments WHERE patient_id = 917169;
