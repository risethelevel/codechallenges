class Solution:
    def checkIfPangram(self, sentence: str) -> bool:
        DATA = 'ABCDEFGHIJKLMNOPQRSTUVWXYZ'
        char_count = { char_value:0 for char_value in DATA.lower() }
        for character in sentence.lower():
            if character in char_count:
                char_count[character] += 1
                
        for _,value in char_count.items():
            if value == 0:
                return False
                
        return True
