# MorseCodeRest
A tiny API to translate morse code into standard letters/numbers.

The following image was used as reference to morse code:

![image](https://user-images.githubusercontent.com/40148361/181437848-f66162d2-2a60-4a63-a439-3e0030823a73.png)

## Installation

The easiest way to get this API running is by using Visual Studio. Follow these steps:

1. Clone this git repository to your device
2. Run it with Visual Studio.

## Usage

There are currently only two endpoints: 
- /api/translate?morseCharacter=[morseCharacter]
- /api/translate/word?morseCharactersSeperatedBySpace=[morseCharacter] [morseCharacter] [morseCharacter]

You can see all endpoints when you have it running at this url: `localhost:[yourPort]/swagger`

You can also access it in your browser through something like this url:

`http://localhost:62032/api/translate?morseCharacter=.`

[baseUrl]/api/translate?morseCharacter=[morseCharacterInput]

### Curl Examples

Example: `curl -X GET "http://localhost:62032/api/translate?morseCharacter=." -H  "accept: */*"`

Output: `E`

Example with word: `curl -X GET "http://localhost:62032/api/translate/word?morseCharactersSeperatedBySpace=...%20---%20..." -H  "accept: */*"`

Output: `SOS`

### JavaScript examples

Translating single morse character:

![image](https://user-images.githubusercontent.com/40148361/181457869-4fd732b2-fa60-4aac-bdeb-7c99b51ac392.png)

![image](https://user-images.githubusercontent.com/40148361/181268648-a1576dce-86dd-4e61-a857-490703cc06b7.png)

Translating word:

![image](https://user-images.githubusercontent.com/40148361/181457801-16f34feb-6569-4ac0-878f-1540e1fc41d3.png)

![image](https://user-images.githubusercontent.com/40148361/181457305-dc7c6a88-1b5c-4530-bce7-6a9633a8bcdc.png)



## Maintainer
[Noitcereon](https://github.com/Noitcereon)
