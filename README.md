# MorseCodeRest
A tiny API to translate morse code into standard letters/numbers.


## Installation

The easiest way to get this API running is by using Visual Studio. Follow these steps:

1. Clone this git repository to your device
2. Run it with Visual Studio.

## Usage

There is currently only one endpoint: /api/translate

If you have it running locally you can access it in your browser through something like this url:

`http://localhost:62032/api/translate?morseCharacter=.`

[baseUrl]/api/translate?morseCharacter=[morseCharacterInput]

### Curl Example

Example: `curl -X GET "http://localhost:62032/api/translate?morseCharacter=." -H  "accept: */*"`

Output: `E`

### JavaScript example

![image](https://user-images.githubusercontent.com/40148361/181268648-a1576dce-86dd-4e61-a857-490703cc06b7.png)


## Maintainer
[Noitcereon](https://github.com/Noitcereon)
