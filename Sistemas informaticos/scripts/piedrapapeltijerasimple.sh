#!/bin/bash

#Pide por teclado la elección del jugador1 y jugador2, suponiendo que solo pueden elegir entre piedra, papel o tijeras.
#Se indicará el jugador que gana o si los dos empatan.

read -p "Introduce piedra, papel o tijera" jugador1
read -p "Introduce piedra, papel o tijera" jugador2

comparar () {
	case $jugador1 in 
	"piedra") 
				case $jugador2 in 
				"piedra") echo "empate";;
				"papel") echo "gana jugador 2";;
				"tijeras") echo "gana jugador 1";;
				esac;;
	"papel") 
				case $jugador2 in 
				"piedra") echo "gana jugador 1";;
				"papel") echo "empate";;
				"tijeras") echo "gana jugador 2";;
				esac;;
	"tijeras") 
				case $jugador2 in 
				"piedra") echo "gana jugador 2";;
				"papel") echo "gana jugador 1";;
				"tijeras") echo "empate";;
				esac;;
	esac
}

comparar $jugador1 $jugador2
