#!/bin/bash

find .. -name SentimentClient.java -exec sed -i -e 's/SENTIMENT_KEY/'"$AZURE_SENTIMENT_KEY"'/g' {} \;
find .. -name Constants.java -exec sed -i -e 's/appcenterdroidkey/'"$APPCENTER_DROID_KEY"'/g' {} \;
          