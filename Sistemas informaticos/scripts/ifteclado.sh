#!/bin/bash

read -p "Introduce un número: " numero

if [[ $numero -gt 20 ]]
then
	echo "$numero es mayor que 20"
else
	echo "$numero es menor que 20"
fi

