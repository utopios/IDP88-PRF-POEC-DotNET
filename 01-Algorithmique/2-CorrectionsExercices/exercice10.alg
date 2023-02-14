<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description courant="AFFICHER Response" texte=""/>
    <extension extnom="inactif"/>
    <fonction fctetat="inactif" fctcode=""/>
    <F2 F2lignes="" F2etat="inactif" F2defaut="" F2para=""/>
    <repere repetat="inactif" repcode="-10#10#-10#10#2#2"/>
    <param totalBoucles="5000000" epaisseurLigne="2" epaisseurPoint="2" totalAffichages="1000" maxBoucle="500000" arrondiAuto="vrai" nbDecimales="8"/>
    <item code="200#declarationfonctions" algoitem="FONCTIONS_UTILISEES"/>
    <item code="100#declarationsvariables" algoitem="VARIABLES">
        <item code="1#NOMBRE#Age" algoitem="Age EST_DU_TYPE NOMBRE"/>
        <item code="1#CHAINE#Response" algoitem="Response EST_DU_TYPE CHAINE"/>
    </item>
    <item code="101#debutalgo" algoitem="DEBUT_ALGORITHME">
        <item code="4#Veuillez saisir l'age de votre enfant : #0" algoitem="AFFICHER &quot;Veuillez saisir l'age de votre enfant : &quot;"/>
        <item code="2#Age#pasliste" algoitem="LIRE Age"/>
        <item code="6#Age &lt; 3" algoitem="SI (Age &lt; 3) ALORS">
            <item code="7#debutsi" algoitem="DEBUT_SI"/>
            <item code="5#Response#&quot;Votre enfant est trop jeune&quot;#pasliste" algoitem="Response PREND_LA_VALEUR &quot;Votre enfant est trop jeune&quot;"/>
            <item code="8#finsi" algoitem="FIN_SI"/>
            <item code="9#sinon" algoitem="SINON">
                <item code="10#debutsinon" algoitem="DEBUT_SINON"/>
                <item code="6#Age >=3 ET Age &lt;=6" algoitem="SI (Age >=3 ET Age &lt;=6) ALORS">
                    <item code="7#debutsi" algoitem="DEBUT_SI"/>
                    <item code="5#Response#&quot;Votre enfant est dans la catégorie Baby.&quot;#pasliste" algoitem="Response PREND_LA_VALEUR &quot;Votre enfant est dans la catégorie Baby.&quot;"/>
                    <item code="8#finsi" algoitem="FIN_SI"/>
                    <item code="9#sinon" algoitem="SINON">
                        <item code="10#debutsinon" algoitem="DEBUT_SINON"/>
                        <item code="6#Age ==7 OU Age ==8" algoitem="SI (Age ==7 OU Age ==8) ALORS">
                            <item code="7#debutsi" algoitem="DEBUT_SI"/>
                            <item code="5#Response#&quot;Votre enfant est dans la catégorie Poussin.&quot;#pasliste" algoitem="Response PREND_LA_VALEUR &quot;Votre enfant est dans la catégorie Poussin.&quot;"/>
                            <item code="8#finsi" algoitem="FIN_SI"/>
                            <item code="9#sinon" algoitem="SINON">
                                <item code="10#debutsinon" algoitem="DEBUT_SINON"/>
                                <item code="6#Age ==9 OU Age ==10" algoitem="SI (Age ==9 OU Age ==10) ALORS">
                                    <item code="7#debutsi" algoitem="DEBUT_SI"/>
                                    <item code="5#Response#&quot;Votre enfant est dans la catégorie Pupille.&quot;#pasliste" algoitem="Response PREND_LA_VALEUR &quot;Votre enfant est dans la catégorie Pupille.&quot;"/>
                                    <item code="8#finsi" algoitem="FIN_SI"/>
                                    <item code="9#sinon" algoitem="SINON">
                                        <item code="10#debutsinon" algoitem="DEBUT_SINON"/>
                                        <item code="6#Age ==11 OU Age ==12" algoitem="SI (Age ==11 OU Age ==12) ALORS">
                                            <item code="7#debutsi" algoitem="DEBUT_SI"/>
                                            <item code="5#Response#&quot;Votre enfant est dans la catégorie Minime.&quot;#pasliste" algoitem="Response PREND_LA_VALEUR &quot;Votre enfant est dans la catégorie Minime.&quot;"/>
                                            <item code="8#finsi" algoitem="FIN_SI"/>
                                            <item code="9#sinon" algoitem="SINON">
                                                <item code="10#debutsinon" algoitem="DEBUT_SINON"/>
                                                <item code="6#Age >=13 ET Age &lt;18" algoitem="SI (Age >=13 ET Age &lt;18) ALORS">
                                                    <item code="7#debutsi" algoitem="DEBUT_SI"/>
                                                    <item code="5#Response#&quot;Votre enfant est dans la catégorie Cadet.&quot;#pasliste" algoitem="Response PREND_LA_VALEUR &quot;Votre enfant est dans la catégorie Cadet.&quot;"/>
                                                    <item code="8#finsi" algoitem="FIN_SI"/>
                                                    <item code="9#sinon" algoitem="SINON">
                                                        <item code="10#debutsinon" algoitem="DEBUT_SINON"/>
                                                        <item code="5#Response#&quot;Ce n'est plus un enfant!&quot;#pasliste" algoitem="Response PREND_LA_VALEUR &quot;Ce n'est plus un enfant!&quot;"/>
                                                        <item code="11#finsinon" algoitem="FIN_SINON"/>
                                                    </item>
                                                </item>
                                                <item code="11#finsinon" algoitem="FIN_SINON"/>
                                            </item>
                                        </item>
                                        <item code="11#finsinon" algoitem="FIN_SINON"/>
                                    </item>
                                </item>
                                <item code="11#finsinon" algoitem="FIN_SINON"/>
                            </item>
                        </item>
                        <item code="11#finsinon" algoitem="FIN_SINON"/>
                    </item>
                </item>
                <item code="11#finsinon" algoitem="FIN_SINON"/>
            </item>
        </item>
        <item code="3#Response#0#pasliste" algoitem="AFFICHER Response"/>
    </item>
    <item code="102#finalgo" algoitem="FIN_ALGORITHME"/>
</Algo>
