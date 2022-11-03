SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

SET default_tablespace = '';

SET default_table_access_method = heap;

CREATE TABLE public."Botoa" (
    "Id" bigint NOT NULL,
    "ErabiltzaileaId" character(9) NOT NULL,
    "ErrezetaId" bigint NOT NULL,
    "Urtea" character(4) NOT NULL,
    "Komentarioa" character varying(150) NOT NULL
);


ALTER TABLE public."Botoa" ALTER COLUMN "Id" ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public."Botoa_Id_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);

CREATE TABLE public."Erabiltzailea" (
    "Id" character(9) NOT NULL,
    "Izena" character varying(50) NOT NULL,
    "Emaila" character varying(50) NOT NULL,
    "Ezizena" character varying(50) NOT NULL
);

CREATE TABLE public."Errezeta" (
    "Id" bigint NOT NULL,
    "Izena" character varying(20) NOT NULL,
    "Deskribapena" character varying(150) NOT NULL
);


INSERT INTO public."Botoa" OVERRIDING SYSTEM VALUE VALUES (1, '12345678A', 1, '2022', 'Munduko onena');
INSERT INTO public."Botoa" OVERRIDING SYSTEM VALUE VALUES (2, '12345678A', 3, '2021', 'Gustokoena');
INSERT INTO public."Botoa" OVERRIDING SYSTEM VALUE VALUES (3, '12345678A', 2, '2022', 'Bigarren gustokoena');
INSERT INTO public."Botoa" OVERRIDING SYSTEM VALUE VALUES (4, '12345678A', 5, '2022', 'Hau be oso ona da');
INSERT INTO public."Botoa" OVERRIDING SYSTEM VALUE VALUES (6, '98765432B', 4, '2021', 'Ona');
INSERT INTO public."Botoa" OVERRIDING SYSTEM VALUE VALUES (7, '11111111D', 2, '2021', 'Ona');
INSERT INTO public."Botoa" OVERRIDING SYSTEM VALUE VALUES (8, '11111111D', 3, '2022', 'Ona');
INSERT INTO public."Botoa" OVERRIDING SYSTEM VALUE VALUES (9, '11111111D', 1, '2022', 'Ona');
INSERT INTO public."Botoa" OVERRIDING SYSTEM VALUE VALUES (10, '22222222E', 3, '2020', 'Ona');
INSERT INTO public."Botoa" OVERRIDING SYSTEM VALUE VALUES (11, '22222222E', 5, '2020', 'Munduko errezeta famosuena');
INSERT INTO public."Botoa" OVERRIDING SYSTEM VALUE VALUES (12, '33333333F', 3, '2020', 'Oso ona');
INSERT INTO public."Botoa" OVERRIDING SYSTEM VALUE VALUES (13, '32343567C', 1, '2022', 'Niretzat onena');
INSERT INTO public."Botoa" OVERRIDING SYSTEM VALUE VALUES (14, '32343567C', 2, '2020', 'Oso ona');
INSERT INTO public."Botoa" OVERRIDING SYSTEM VALUE VALUES (15, '32343567C', 4, '2021', 'Munduko errezeta famosuena');
INSERT INTO public."Botoa" OVERRIDING SYSTEM VALUE VALUES (16, '32343567C', 5, '2022', 'Munduko errezeta famosuena');
INSERT INTO public."Botoa" OVERRIDING SYSTEM VALUE VALUES (17, '32343567C', 2, '2022', 'Bigarren onena');
INSERT INTO public."Botoa" OVERRIDING SYSTEM VALUE VALUES (18, '11111111D', 4, '2022', 'Viva Mexico');


INSERT INTO public."Erabiltzailea" VALUES ('12345678A', 'Paco Martinez', 'pmartinez@gmail.com', 'marti');
INSERT INTO public."Erabiltzailea" VALUES ('98765432B', 'Maria Ruiz', 'mruiz@gmail.com', 'maritxu');
INSERT INTO public."Erabiltzailea" VALUES ('32343567C', 'Lourdes Perez', 'lperez@gmail.com', 'lou');
INSERT INTO public."Erabiltzailea" VALUES ('11111111D', 'pepe perez', 'pperez@gmail.com', 'pepito');
INSERT INTO public."Erabiltzailea" VALUES ('22222222E', 'Juan Goitia', 'jgoitia@gmail.com', 'juanito');
INSERT INTO public."Erabiltzailea" VALUES ('33333333F', 'Pedro Txakartegi', 'ptxakartegi', 'Pe');


INSERT INTO public."Errezeta" VALUES (2, 'Pizza', 'Ogi biribila eta osagiarekin gainean jarrita. Laban egiten da.');
INSERT INTO public."Errezeta" VALUES (3, 'Burguer', 'Oso plater gomendagarria, baldin eta kalitatezko haragia, osagai freskoak eta saltsak gehiegi erabiltzen ez badira.
');
INSERT INTO public."Errezeta" VALUES (4, 'Burrito', 'Gari-tortilla biribilkatua, asto baten belarriaren antzekoa eta okela eta barazkiekin beteta
');
INSERT INTO public."Errezeta" VALUES (5, 'Sushi', 'Japoniak munduko gainerako herrialdeetara esportatzea lortu duen platera arroz egosiz, algaz, barazkiz eta arrain gordinez egiten da
');
INSERT INTO public."Errezeta" VALUES (1, 'Paella', 'Arrozarekin egindako platera eta beste osagaien artean, arraina edo okela eduki dezake ');


ALTER TABLE ONLY public."Botoa"
    ADD CONSTRAINT "Botoa_pkey" PRIMARY KEY ("Id");

ALTER TABLE ONLY public."Erabiltzailea"
    ADD CONSTRAINT "Erabiltzailea_pkey" PRIMARY KEY ("Id");

ALTER TABLE ONLY public."Errezeta"
    ADD CONSTRAINT "Errezeta_pkey" PRIMARY KEY ("Id");



