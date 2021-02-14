# DemoXamarinWebApi

-------------------------------------------------- ESPAÑOL-----------------------------------------------------------------------
Login a traves de xamarin con ASP.NET Web API IIS

Por favor considerar los siguientes pasos para poder correr la aplicacion.

1)Esta aplicacion corre corre con motor de base de datos MySql, por lo que se requiere instalar este previamente, personalmente
yo ocupe para esta ocasion XAMP para la instalacion. la base de datos debe quedar instalada en el puerto 3306.

La cadena de conexion en el programa para la base de datos sera: "server=localhost;port=3306;database=cloudtecnologias;username=root;"

2) El Script para la base de datos se encuentra en el Repositorio, en caso de que no les funcione, porfavor usen el siguiente Script

CREATE DATABASE CLOUDTECNOLOGIAS;
USE CLOUDTECNOLOGIAS;
CREATE TABLE TESTUSER
(
CUSTOMER_ID INT PRIMARY KEY AUTO_INCREMENT,
NAME VARCHAR(64) NOT NULL,
EMAIL VARCHAR(64) NOT NULL,
PASS VARCHAR(64) NOT NULL
);

3) Luego, para poder montar la Web API, se quiere montar una pagina web a traves de IIS y añadir el Proyecto "WebApi" publicado en ella. La direccion debe ser 192.168.0.13 puerto 8088
(192.168.0.13:8088). Si es la primera vez que ejecutan los servicios IIS, Abran "Agregar o desactivar caracteristicas de Windows-> Internet Information Services" y seleccionar "Herramientas de administración web" y "Servicios World Wide Web". deben asegurarse que queden todos las
caracteristicas de estas activadas.

Adjunto video tutorial de como montar el IIS: https://www.youtube.com/watch?v=tSpQFuHCWbM&ab_channel=RickyIslam

4)una vez montada la web api, Abran el proyecto con Visual Studio 2019, seleccionen "Establecer como proyecto de inicio" en "Movil.Android" y listo, la App deberia estar corriendo en conjunto con la WebApi.



