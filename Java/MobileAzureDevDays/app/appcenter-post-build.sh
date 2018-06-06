#!/bin/bash

npm install -g appcenter-cli

appcenter login --token $APPCENTER_TOKEN

APKFile=`find . -name '*Test.apk'`
echo $APKFile
appcenter test run espresso --app "Mahdis-Org/Java-Sample-AppCenter" --devices "Mahdis-Org/latest-and-greatest" --app-path APKFile --test-series "master" --locale "en_US" --build-dir '"$APPCENTER_SOURCE_DIRECTORY"'/app/build/outputs/apk'