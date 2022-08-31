import os
from bs4 import BeautifulSoup as bs
import requests

## THIS SCRIPT IS FOR ACADEMIC DOCUMENTATION ONLY AND IS NEVER RUN!
## It was used in development to generate the data insert statment.
## To insert this data, please open the 'createTranslationsDB.sql' provided!

def getWebpageInfoByTag(rssLink, tag):
    req = requests.get(rssLink, "cacert.pem")
    soup = bs(req.content, 'html.parser')
    info = soup.find_all(tag)
    return info

url = 'https://1000mostcommonwords.com/1000-most-common-portuguese-words/'
info = getWebpageInfoByTag(url, 'tr')

col = 0
wordID = 0
query = 'INSERT INTO translations.words VALUES'

for tr in info:
                trRows = tr.text.splitlines()
                ## print (trRows[1],' ')
                if wordID == 0:
                        print("\n")
                else:
                        query += "("+str(wordID)+",'"+trRows[3].strip() + "', '"
                        if wordID == 1000:
                                query += trRows[2].strip() + "' ,0,0,0);"
                        else:
                                query += trRows[2].strip() + "' ,0,0,0),"
                wordID +=1

print (query)
print("\n---------------------------------\n")
         
        
