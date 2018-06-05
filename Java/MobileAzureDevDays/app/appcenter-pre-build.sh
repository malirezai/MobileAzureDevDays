#!/bin/bash

find .. -name SentimentClient.java -exec sed -i -e 's/SENTIMENT_KEY/'"$AZURE_SENTIMENT_KEY"'/g' {} \;