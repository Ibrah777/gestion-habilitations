CREATE DATABASE IF NOT EXISTS habilitations CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE habilitations;

CREATE TABLE IF NOT EXISTS profil (
    idprofil INT AUTO_INCREMENT PRIMARY KEY,
    libelle VARCHAR(50) NOT NULL
);

CREATE TABLE IF NOT EXISTS developpeur (
    iddeveloppeur INT AUTO_INCREMENT PRIMARY KEY,
    nom VARCHAR(50) NOT NULL,
    prenom VARCHAR(50) NOT NULL,
    tel VARCHAR(20),
    mail VARCHAR(100),
    pwd VARCHAR(100) NOT NULL,
    idprofil INT NOT NULL,
    FOREIGN KEY (idprofil) REFERENCES profil(idprofil)
);

INSERT INTO profil (libelle) VALUES
    ('admin'),
    ('stagiaire'),
    ('designer'),
    ('dev-front'),
    ('dev-back');

INSERT INTO developpeur (nom, prenom, tel, mail, pwd, idprofil) VALUES
    ('Dione', 'Ibrahima', '06 12 34 56 78', 'ibrahima@mail.com', 'Dione', 1),
    ('Martin', 'Sophie', '07 98 76 54 32', 'sophie@mail.com', 'Martin', 4),
    ('Dupont', 'Kevin', '06 55 44 33 22', 'kevin@mail.com', 'Dupont', 5);
