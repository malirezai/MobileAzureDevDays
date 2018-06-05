#!/bin/bash

npm install -g appcenter-cli

APKFile=`find . -name '*Test.apk'`

appcenter test run espresso --app "Mahdis-Org/Java-Sample-AppCenter" --devices "Mahdis-Org/latest-and-greatest" --app-path APKFile --test-series "master" --locale "en_US" --build-dir 'app/build/outputs/apk'