# Circa2001
A farily straight forward N-Layer application example

This is an application I've had for years which just shows a simple way of using ADO.net to access a Northwind database.
As the title says, this is based off of a 2001 style application, so there is nothing really fancy here. 

The appliaction is broken up into 5 different projects. 

## Project.Web

Simple web form based application which consumes data which comes from a business logic layer. 

## Project.BLL

Basically a service layer which consumes the data access methods. 

## Project.DAL

This layer is where we actually have SQL data readers and, paramtized queries and SQL strings. 

## Project.Domain

We have a couple of domain entity objects here. 

## Generic.DataAcess

SQL Helper, SQL Exception helper and a connectin string helper all live here. 

## Supporting Documents

We all need to have a database, and Microsoft's Northwind scripts live here. 
Probably should have a MS SQL server in place. SQL Express is a good start. 
