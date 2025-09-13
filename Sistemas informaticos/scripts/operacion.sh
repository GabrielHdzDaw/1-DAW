#!/bin/bash

suma () {
    echo $(( $1 + $2 ))
}

resta () {
    echo $(( $1 - $2 ))
}

multi () {
    echo $(( $1 * $2 ))
}

divi () {
    if [[ $2 -eq 0 ]]; then
        echo "Error: División por cero"
        exit 1
    fi
    echo $(( $1 / $2 ))
}

mod () {
    if [[ $2 -eq 0 ]]; then
        echo "Error: Módulo por cero"
        exit 1
    fi
    echo $(( $1 % $2 ))
}

operando1=$1
operando2=$2
operacion=$3

case "$operacion" in 
    +) suma $operando1 $operando2 ;;
    -) resta $operando1 $operando2 ;;
    x) multi $operando1 $operando2 ;;
    /) divi $operando1 $operando2 ;;
    %) mod $operando1 $operando2 ;;
    *) echo "Operación no válida"; exit 1 ;;
esac

