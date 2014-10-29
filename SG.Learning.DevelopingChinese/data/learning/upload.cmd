@setlocal enabledelayedexpansion
set suffixTime=%time: =0%
set suffixDate=%date:/=-%
set suffix=%suffixDate%T%suffixTime::=_%
curl --form "file_1=@flash.xml;filename=flash_%suffix%.xml" --form "data_bytesAvailable=1266155520&data_currentParams=%3Fuploader%3Dbasic" "http://192.168.1.17:1234/mnt/sdcard/?uploader=basic"
