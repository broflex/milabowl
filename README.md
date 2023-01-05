# Milabowl content

This page is used for adding content "dynamically" to milabowl. Some pages might fetch data from json files in this branch, using github APIs. Currently only nominations is supported through nominations.json file.

## Nominations.json
Nominations.json contains a list of all nominations throughout a season, and will be curated and updated as we go along. Category enum is currently defined as follows:
 - DERP, LUCK, SHAME, FAIL

To add nomination simply add a new object to the Nominasions.json list (use existing entries as examples). Updates can be merged directly into the content branch.
