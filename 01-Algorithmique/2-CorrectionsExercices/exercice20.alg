<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description courant="FIN_TANT_QUE" texte=""/>
    <extension extnom="inactif"/>
    <fonction fctetat="inactif" fctcode=""/>
    <F2 F2etat="inactif" F2defaut="" F2lignes="" F2para=""/>
    <repere repetat="inactif" repcode="-10#10#-10#10#2#2"/>
    <param totalBoucles="5000000" maxBoucle="500000" arrondiAuto="vrai" nbDecimales="8" totalAffichages="1000" epaisseurPoint="2" epaisseurLigne="2"/>
    <item algoitem="FONCTIONS_UTILISEES" code="200#declarationfonctions"/>
    <item algoitem="VARIABLES" code="100#declarationsvariables">
        <item algoitem="NoteTMP EST_DU_TYPE NOMBRE" code="1#NOMBRE#NoteTMP"/>
        <item algoitem="Max EST_DU_TYPE NOMBRE" code="1#NOMBRE#Max"/>
        <item algoitem="Min EST_DU_TYPE NOMBRE" code="1#NOMBRE#Min"/>
        <item algoitem="Notes EST_DU_TYPE NOMBRE" code="1#NOMBRE#Notes"/>
        <item algoitem="NbNotes EST_DU_TYPE NOMBRE" code="1#NOMBRE#NbNotes"/>
        <item algoitem="i EST_DU_TYPE NOMBRE" code="1#NOMBRE#i"/>
        <item algoitem="choix EST_DU_TYPE NOMBRE" code="1#NOMBRE#choix"/>
    </item>
    <item algoitem="DEBUT_ALGORITHME" code="101#debutalgo">
        <item algoitem="Notes PREND_LA_VALEUR 0" code="5#Notes#0#pasliste"/>
        <item algoitem="NbNotes PREND_LA_VALEUR 0" code="5#NbNotes#0#pasliste"/>
        <item algoitem="//Récupération des saisies utilisateur" code="19#Récupération des saisies utilisateur"/>
        <item algoitem="POUR i ALLANT_DE 1 A 20" code="12#i#1#20">
            <item algoitem="DEBUT_POUR" code="13#debutpour"/>
            <item algoitem="AFFICHER &quot;Veuillez saisir la note  &quot;" code="4#Veuillez saisir la note  #0"/>
            <item algoitem="AFFICHER i" code="3#i#0#pasliste"/>
            <item algoitem="AFFICHER &quot; comprise entre 0 et 20 :&quot;" code="4# comprise entre 0 et 20 :#0"/>
            <item algoitem="LIRE NoteTMP" code="2#NoteTMP#pasliste"/>
            <item algoitem="SI (NoteTMP >=0 ET NoteTMP&lt;=20) ALORS" code="6#NoteTMP >=0 ET NoteTMP&lt;=20">
                <item algoitem="DEBUT_SI" code="7#debutsi"/>
                <item algoitem="SI (i == 1) ALORS" code="6#i == 1">
                    <item algoitem="DEBUT_SI" code="7#debutsi"/>
                    <item algoitem="Max PREND_LA_VALEUR NoteTMP" code="5#Max#NoteTMP#pasliste"/>
                    <item algoitem="Min PREND_LA_VALEUR NoteTMP" code="5#Min#NoteTMP#pasliste"/>
                    <item algoitem="FIN_SI" code="8#finsi"/>
                    <item algoitem="SINON" code="9#sinon">
                        <item algoitem="DEBUT_SINON" code="10#debutsinon"/>
                        <item algoitem="SI (NoteTMP &lt; Min) ALORS" code="6#NoteTMP &lt; Min">
                            <item algoitem="DEBUT_SI" code="7#debutsi"/>
                            <item algoitem="Min PREND_LA_VALEUR NoteTMP" code="5#Min#NoteTMP#pasliste"/>
                            <item algoitem="FIN_SI" code="8#finsi"/>
                        </item>
                        <item algoitem="SI (NoteTMP > Max) ALORS" code="6#NoteTMP > Max">
                            <item algoitem="DEBUT_SI" code="7#debutsi"/>
                            <item algoitem="Max PREND_LA_VALEUR NoteTMP" code="5#Max#NoteTMP#pasliste"/>
                            <item algoitem="FIN_SI" code="8#finsi"/>
                        </item>
                        <item algoitem="FIN_SI" code="8#finsi"/>
                    </item>
                </item>
                <item algoitem="Notes PREND_LA_VALEUR Notes + NoteTMP" code="5#Notes#Notes + NoteTMP#pasliste"/>
                <item algoitem="NbNotes PREND_LA_VALEUR NbNotes + 1" code="5#NbNotes#NbNotes + 1#pasliste"/>
                <item algoitem="FIN_SINON" code="11#finsinon"/>
            </item>
            <item algoitem="FIN_POUR" code="14#finpour"/>
        </item>
        <item algoitem="//Affichage du menu" code="19#Affichage du menu"/>
        <item algoitem="choix PREND_LA_VALEUR -1" code="5#choix#-1#pasliste"/>
        <item algoitem="TANT_QUE (choix != 0) FAIRE" code="15#choix != 0">
            <item algoitem="DEBUT_TANT_QUE" code="16#debuttantque"/>
            <item algoitem="SI (choix == 1) ALORS" code="6#choix == 1">
                <item algoitem="DEBUT_SI" code="7#debutsi"/>
                <item algoitem="AFFICHER &quot;La plus petite note est : &quot;" code="4#La plus petite note est : #0"/>
                <item algoitem="AFFICHER Min" code="3#Min#0#pasliste"/>
                <item algoitem="AFFICHER &quot;/20.&quot;" code="4#/20.#1"/>
                <item algoitem="FIN_SI" code="8#finsi"/>
                <item algoitem="SINON" code="9#sinon">
                    <item algoitem="DEBUT_SINON" code="10#debutsinon"/>
                    <item algoitem="SI (choix == 2) ALORS" code="6#choix == 2">
                        <item algoitem="DEBUT_SI" code="7#debutsi"/>
                        <item algoitem="AFFICHER &quot;La plus grande note est : &quot;" code="4#La plus grande note est : #0"/>
                        <item algoitem="AFFICHER Max" code="3#Max#0#pasliste"/>
                        <item algoitem="AFFICHER &quot;/20.&quot;" code="4#/20.#1"/>
                        <item algoitem="FIN_SI" code="8#finsi"/>
                        <item algoitem="SINON" code="9#sinon">
                            <item algoitem="DEBUT_SINON" code="10#debutsinon"/>
                            <item algoitem="SI (choix == 3) ALORS" code="6#choix == 3">
                                <item algoitem="DEBUT_SI" code="7#debutsi"/>
                                <item algoitem="AFFICHER &quot;La moyenne des notes est : &quot;" code="4#La moyenne des notes est : #0"/>
                                <item algoitem="AFFICHERCALCUL round(Notes/NbNotes)" code="20#round(Notes/NbNotes)#0"/>
                                <item algoitem="AFFICHER &quot;/20.&quot;" code="4#/20.#1"/>
                                <item algoitem="FIN_SI" code="8#finsi"/>
                                <item algoitem="SINON" code="9#sinon">
                                    <item algoitem="DEBUT_SINON" code="10#debutsinon"/>
                                    <item algoitem="AFFICHER &quot;Merci de choisr entre 0 et 3&quot;" code="4#Merci de choisr entre 0 et 3#1"/>
                                    <item algoitem="FIN_SINON" code="11#finsinon"/>
                                </item>
                            </item>
                            <item algoitem="FIN_SINON" code="11#finsinon"/>
                        </item>
                    </item>
                    <item algoitem="FIN_SINON" code="11#finsinon"/>
                </item>
            </item>
            <item algoitem="AFFICHER &quot;\t1) Afficher la plus petite note\n\t2) Afficher la plus grande note\n\t3) Afficher la moyenne des notes\n\t0) Quitter&quot;" code="4#\t1) Afficher la plus petite note\n\t2) Afficher la plus grande note\n\t3) Afficher la moyenne des notes\n\t0) Quitter#1"/>
            <item algoitem="AFFICHER &quot;\nVeuillez faire votre choix : &quot;" code="4#\nVeuillez faire votre choix : #0"/>
            <item algoitem="LIRE choix" code="2#choix#pasliste"/>
            <item algoitem="FIN_TANT_QUE" code="17#fintantque"/>
        </item>
    </item>
    <item algoitem="FIN_ALGORITHME" code="102#finalgo"/>
</Algo>
