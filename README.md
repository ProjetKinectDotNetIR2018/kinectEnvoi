# kinectenvoi
Le programme Kinect Envoi permet d'envoyer une réponse ("oui" ou "non") en fonction de la position de la main droite de l'utilisateur détectée par la kinect. La réponse est oui si l'utilisateur met sa main droite en haut à droite et la réponse est "non" si l'utilisateur met sa main droite en haut à gauche.  
Cette réponse est envoyée sur le middle office au format JSON et est ensuite récupérée et gérée par le programme Kinect Réception.  
  
Format JSON de la réponse:  
oui : envoi un objet Answer("1",null,null)   
{  
    "code" : "1",  
    "summary" : null,  
    "action" : null  
}  
  
non  : envoi un objet Answer("0",null,null)  
{  
    "code" : "0",  
    "summary" : null,  
    "action" : null  
}  
  
Nous avons pensé qu'il était beaucoup plus simple d'envoyer seulement un objet Answer avec seulement l'attribut code et le reste à null dans un fichier JSON plutôt que d'envoyer un objet Vote complet. En effet il sera plus simple de créer l'objet vote par le programme réception.  
Cependant, par manque de temps, nous n'avons pas eu le temps de bien synchroniser et tester les deux programmes.


