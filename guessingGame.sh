#!usr/bin/bash

echo "Guess the secret number!"
randomNumber=$(( ($RANDOM % 100) + 1 ))
#echo $randomNumber
times=0
read number
#if [ $(( $number < 0 )) -eq 0 ] || [ $(( $number > 100 )) -eq 0 ]
#then
  #echo Number is out of range!
  #break
#fi
#echo $number
while [ $number -ne $randomNumber ]
do
  times=$((times+1))
  if [ $(($randomNumber - $number)) -le 10 ] && [ $(($randomNumber - $number)) -ge 1 ]
  then
    echo "It's a bit too small!"
    echo "You are on try number " $((times))". Try again!"
    read number
  elif [ $(($number - $randomNumber)) -le 10 ] && [ $(($number - $randomNumber)) -ge 1 ]
  then
    echo "It's a bit too big!"
    echo "You are on try number" $((times))". Try again!"
    read number
  elif [ $(($randomNumber - $number)) -gt 10 ] && [ $(($randomNumber - $number)) -le 25 ]
  then
    echo "The guess is too low!"
    echo "You are on try number" $((times))". Try again!"
    read number
  elif [ $(($number - $randomNumber)) -gt 10 ] && [ $(($number - $randomNumber)) -le 25 ]
  then
    echo "The guess is too high!"
    echo "You are on try number" $((times))". Try again!"
    read number
  elif [ $(($randomNumber - $number)) -gt 25 ]
  then
    echo "The guess is WAY too low!"
    echo "You are on try number" $((times))". Try again!"
    #echo $randomNumber
    read number
  elif [ $(($number - $randomNumber)) -gt 25 ]
  then
    echo "The guess is WAY too high!"
    echo "You are on try number" $((times)) ". Try again!"
    #echo $randomNumber
    read number
  fi

done
times=$((times+1))
echo "You got it!"
echo "It took" $((times)) "attempts!"
