from collections import defaultdict
class Solution:
    def findWinners(self, matches: List[List[int]]) -> List[List[int]]:
        losers = defaultdict(int)
        winners = set()
        just_one_loss = set()
        
        for match in matches:
            losers[match[1]]+=1
        for match in matches:
            if match[0] not in losers:
                winners.add(match[0])
            if match[0] in losers and losers[match[0]] == 1:
                just_one_loss.add(match[0])
            if match[1] in losers and losers[match[1]] == 1:
                just_one_loss.add(match[1])
        answer = [sorted(list(winners)), sorted(list(just_one_loss))]
        return answer