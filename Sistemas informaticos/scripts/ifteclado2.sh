#!/bin/bash

read -p "Introduce un número: " numero

if [[ $numero -gt 20 ]]
then
	echo "$numero es mayor que 20"
elif [[ $numero -ge 10 && $numero -le 19 ]]
then
	echo "$numero está entre 10 y 19"
elif [[ $numero -lt 10 ]]
then
	echo "$numero es menor que 10"
fi

