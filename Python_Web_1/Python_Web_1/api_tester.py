import json;
import requests;
import pyshopee;
import pyfacebook;
response = requests.get('https://jsonplaceholder.typicode.com/todos/1');
print(response.json());

#response = requests.post(
#    "https://apis.paralleldots.com/v4/similarity",
#    data = {
#        "text_1": "hello nghi",
#        "text_2": "hi nghi",
#        "api_key": "KtchBvhGCa4Ad6DazznID2a9wD5Wo5rrNhjcxZtTK9E"
#            }
#    );
#print(response.content);
