#!/bin/bash

read -p "número: " num
if [[ num -ge 1 && num -le 100 ]]
then
	echo "$num está entre 1 y 100"
else
	echo "$num no está entre 1 y 100"
fi
