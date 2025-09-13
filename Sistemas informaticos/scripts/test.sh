#!/bin/bash

username=$(whoami)
weekday=$(date +"%A")
month=$(date +"%B")
day=$(date +"%d")
current_time=$(date +"%H:%M")
echo -e "Hola, $username.\nHoy es $weekday $day de $month y son las $current_time"
