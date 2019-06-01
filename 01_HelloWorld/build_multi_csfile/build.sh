#!/bin/bash

OUT=main.exe

if [ "$1" = "clear" ]; then
	rm -f $OUT
	exit 0
fi

mcs *.cs -out:${OUT}
