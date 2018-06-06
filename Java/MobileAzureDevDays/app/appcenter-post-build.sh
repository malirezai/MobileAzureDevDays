#!/bin/bash

npm install -g appcenter-cli

appcenter login --token $APPCENTER_TOKEN

./gradlew assembleDebugAndroidTest 

APKFile=`find . -name '*Test.apk'`
echo $APKFile
if ["$APPCENTER_SOURCE_DIRECTORY" == ""]; 
then
   appcenter test run espresso --app "Mahdis-Org/Java-Sample-AppCenter" --devices "Mahdis-Org/latest-and-greatest" --app-path APKFile --test-series "master" --locale "en_US" --build-dir $CIRCLE_WORKING_DIRECTORY/app/build/outputs/apk 
else
    appcenter test run espresso --app "Mahdis-Org/Java-Sample-AppCenter" --devices "Mahdis-Org/latest-and-greatest" --app-path APKFile --test-series "master" --locale "en_US" --build-dir $APPCENTER_SOURCE_DIRECTORY/Java/MobileAzureDevDays/app/build/outputs/apk
fi