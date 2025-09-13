#!/bin/bash

if ["$(ping -c 1 8.8.8.8 | grep received | cut -d ',' -f2 | cut -d ' ' -f2)" -eq 1]
then
	echo "Google responde"
else
	echo "Google no responde"
fi

