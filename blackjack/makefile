
# directories

D_ROOT := $(shell pwd)

# project configuration
TARGET := blackjack

make:
	@ dotnet build

run: make
	@ bin/Debug/net8.0/$(TARGET)

clean:
	@ dotnet clean
	