#!/bin/bash

secreta="migrabiel"

echo "Adivina la palabra"
read -s  palabra

if [[ $secreta == $palabra ]]
then
	echo "Muy bien"
else
	echo "Muy mal"
fi
