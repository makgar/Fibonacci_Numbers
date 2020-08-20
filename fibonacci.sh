#!/bin/bash

if [ $# -eq 0 ]; then
	echo "No arguments provided."
elif [ $# -gt 1 ]; then
	echo "More than 1 argument provided. Taking first argument as operand."
	SEQ_NUM=$1
else
	SEQ_NUM=$1
fi

echo "Please note that I consider 0 to be F0!"
REGEXP="^[0-9]+$"
until [[ $SEQ_NUM =~ $REGEXP ]]; do
	echo -e "Value is NaN.\nWhich Fibonnaci sequence number do you wish to get the value for?"
	read SEQ_NUM
done

FIBONACCI=()
FIBONACCI[0]=0
FIBONACCI[1]=1

COUNTER=2
while [ $COUNTER -le $SEQ_NUM ]; do
	FIBONACCI[$COUNTER]=$((${FIBONACCI[$(($COUNTER-2))]}+${FIBONACCI[$(($COUNTER-1))]}))
	#echo ${FIBONACCI[$COUNTER]}
	COUNTER=$(($COUNTER+1))
done
echo -e "Fibonacci sequence number $SEQ_NUM equals:\n${FIBONACCI[$SEQ_NUM]}"
