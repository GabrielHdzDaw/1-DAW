#!/bin/bash

for((i=1;i<=$1;i++))
do
	for((j=1;j<=$2;j++))
	do
		if [[ $i -eq 1 || $i -eq $1 || $j -eq 1 || $j -eq $2 ]]
		then
			echo -n "* "
		else
			echo -n "  "
		fi
	done
	echo ""
done
		
