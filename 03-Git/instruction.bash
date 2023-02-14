# Recupérer l'ensemble des commits
$ git log

# Flag pour afficher les comit de maniere succinte
$ git log --oneline

# Flag pour affichage d'un nombre de commit definit
$ git log -n 2

# Flag pour affichage des commit affectant une fichier en particulier
$ git log -p index.html

# Flag pour affichage des commit issus d'un auteur spécifié
$ git log --author Utopios

# Création d'une branche depuis les fichiers présent sur la brancher actuelle
$ git branch <nomDeLaBranche>

# Lister les branches présente dans notre repos local
$ git branch

# Renommer une branche
$ git branch -m <nouveauNomDeLaBranche>

# Supprimmer une branche
$ git branch -d <NomDeLaBranche>

# Se rendre sur une brancher (en faire la branche active)
$ git checkout <NomDeLaBranche>

# Permer de créer une branche depuis la branche actuelle (fichiers) et de d'y rendre directement
$ git checkout -b <nomDeLaBranche>

# Fusionner la branche précisé sur la branche actuelle
$ git merge <nomDeLaBrancheAFusionner>
