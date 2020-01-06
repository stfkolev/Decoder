# Decoder
Decodes PSV files

# Basic Usage

Basic usage is with PluralSight's offline player. You clone this repo, build it up, through cmd(for now) navigate to the folder of the built file and run the command

```
Decoder /F "C:\Users\<your-user>\AppData\Local\Pluralsight\courses" /DB "C:\Users\<your-user>\AppData\Local\Pluralsight\pluralsight.db" /TRANS /RM /OUT "<output_directory>"
```

# Flags

There are a couple of Flags:

* F flag is mandatory.
* DB flag is for routing the database of pluralsight.
* TRANS flag is for transcriptions(subtitles).
* RM flag is for removing the courses from the database, after decrypting
* OUT flag is for the output directory, where the videos with subtitles will be saved
