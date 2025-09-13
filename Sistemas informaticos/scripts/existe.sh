#!/bin/bash

echo "comprobando si $1 existe"
if [ -e $1 ] 
then
	echo "$1 Es un fichero y existe"
else
	echo "$1 no existe. Creando $1"
	touch $1
fi
