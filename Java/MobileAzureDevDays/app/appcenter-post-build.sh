#!/bin/bash

npm install -g appcenter-cli

appcenter login --token $APPCENTER_TOKEN

#build Android Tests
./../gradlew assembleDebugAndroidTest 

if ["$APPCENTER_SOURCE_DIRECTORY" == ""]; 
then
    echo $CIRCLE_ARTIFACTS/*.apk
    appcenter test run espresso --app "Mahdis-Org/Java-Sample-CircleCI" --devices "Mahdis-Org/android-6-thru-8" --app-path $CIRCLE_ARTIFACTS/*.apk --test-series "master" --locale "en_US" --build-dir $CIRCLE_WORKING_DIRECTORY/app/build/outputs/apk 
else
    echo $APPCENTER_OUTPUT_DIRECTORY/*.apk
    appcenter test run espresso --app "Mahdis-Org/Java-Sample-AppCenter" --devices "Mahdis-Org/android-6-thru-8" --app-path $APPCENTER_OUTPUT_DIRECTORY/*.apk --test-series "master" --locale "en_US" --build-dir $APPCENTER_SOURCE_DIRECTORY/Java/MobileAzureDevDays/app/build/outputs/apk
fi
