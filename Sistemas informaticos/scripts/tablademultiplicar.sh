#!/bin/bash

if [[ $# -lt 2 ]]
then
	echo "Debes introducir 2 números como parámetro"
else
	

	if [[ $1 -ge $2 ]]
	then
		let mayor=$1
		let menor=$2
	else
	 	let mayor=$2
	 	let menor=$1
	fi

	for((i=$menor;i<=$mayor;i++))
	do
		for((j=1;j<=10;j++))
		do
			echo "$i x $j = $(($i*$j))"
		done
		echo "--------------"
	done
fi
