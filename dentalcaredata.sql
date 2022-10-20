
-- DDL (database design)

DROP TABLE IF EXISTS [days];

CREATE TABLE [days](
  [id] INTEGER PRIMARY KEY, 
  [name] TEXT,
  UNIQUE([name])) WITHOUT ROWID;


-- SQL (initial data)

INSERT INTO days(id, name) VALUES(0, 'Lunes');
INSERT INTO days(id, name) VALUES(1, 'Martes');
INSERT INTO days(id, name) VALUES(2, 'Miercoles');
INSERT INTO days(id, name) VALUES(3, 'Jueves');
INSERT INTO days(id, name) VALUES(4, 'Viernes');
INSERT INTO days(id, name) VALUES(5, 'Sabado');
INSERT INTO days(id, name) VALUES(6, 'Domingo');

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

