﻿namespace SEOLib

module StopWords =

    let englishStopWords =
        [|
            "a"
            "â"
            "about"
            "above"
            "according"
            "across"
            "actually"
            "ad"
            "adj"
            "ae"
            "af"
            "after"
            "afterwards"
            "ag"
            "again"
            "against"
            "ai"
            "al"
            "all"
            "almost"
            "alone"
            "along"
            "already"
            "also"
            "although"
            "always"
            "am"
            "among"
            "amongst"
            "an"
            "and"
            "another"
            "any"
            "anyhow"
            "anyone"
            "anything"
            "anywhere"
            "ao"
            "aq"
            "ar"
            "are"
            "aren"
            "aren't"
            "around"
            "arpa"
            "as"
            "at"
            "au"
            "aw"
            "az"
            "b"
            "ba"
            "bb"
            "bd"
            "be"
            "became"
            "because"
            "become"
            "becomes"
            "becoming"
            "been"
            "before"
            "beforehand"
            "begin"
            "beginning"
            "behind"
            "being"
            "below"
            "beside"
            "besides"
            "between"
            "beyond"
            "bf"
            "bg"
            "bh"
            "bi"
            "billion"
            "bj"
            "bm"
            "bn"
            "bo"
            "both"
            "br"
            "bs"
            "bt"
            "but"
            "buy"
            "bv"
            "bw"
            "by"
            "bz"
            "c"
            "ca"
            "can"
            "can't"
            "cannot"
            "caption"
            "cc"
            "cd"
            "cf"
            "cg"
            "ch"
            "ci"
            "ck"
            "cl"
            "click"
            "cm"
            "cn"
            "co"
            "co."
            "com"
            "copy"
            "could"
            "couldn"
            "couldn't"
            "cr"
            "cs"
            "cu"
            "cv"
            "cx"
            "cy"
            "cz"
            "d"
            "de"
            "did"
            "didn"
            "didn't"
            "dj"
            "dk"
            "dm"
            "do"
            "does"
            "doesn"
            "doesn't"
            "don"
            "don't"
            "down"
            "during"
            "dz"
            "e"
            "each"
            "ec"
            "edu"
            "ee"
            "eg"
            "eh"
            "eight"
            "eighty"
            "either"
            "else"
            "elsewhere"
            "end"
            "ending"
            "enough"
            "er"
            "es"
            "et"
            "etc"
            "even"
            "ever"
            "every"
            "everyone"
            "everything"
            "everywhere"
            "except"
            "f"
            "few"
            "fi"
            "fifty"
            "find"
            "first"
            "five"
            "fj"
            "fk"
            "fm"
            "fo"
            "for"
            "former"
            "formerly"
            "forty"
            "found"
            "four"
            "fr"
            "free"
            "from"
            "further"
            "fx"
            "g"
            "ga"
            "gb"
            "gd"
            "ge"
            "get"
            "gf"
            "gg"
            "gh"
            "gi"
            "gl"
            "gm"
            "gmt"
            "gn"
            "go"
            "gov"
            "gp"
            "gq"
            "gr"
            "gs"
            "gt"
            "gu"
            "gw"
            "gy"
            "h"
            "had"
            "has"
            "hasn"
            "hasn't"
            "have"
            "haven"
            "haven't"
            "he"
            "he'd"
            "he'll"
            "he's"
            "help"
            "hence"
            "her"
            "here"
            "here's"
            "hereafter"
            "hereby"
            "herein"
            "hereupon"
            "hers"
            "herself"
            "him"
            "himself"
            "his"
            "hk"
            "hm"
            "hn"
            "home"
            "homepage"
            "how"
            "however"
            "hr"
            "ht"
            "htm"
            "html"
            "http"
            "hu"
            "hundred"
            "i"
            "i'd"
            "i'll"
            "i'm"
            "i've"
            "i.e."
            "id"
            "ie"
            "if"
            "ii"
            "il"
            "im"
            "in"
            "inc"
            "inc"
            "inc."
            "indeed"
            "information"
            "instead"
            "int"
            "into"
            "io"
            "iq"
            "ir"
            "is"
            "isn"
            "isn't"
            "it"
            "it's"
            "its"
            "itself"
            "j"
            "je"
            "jm"
            "jo"
            "join"
            "jp"
            "k"
            "ke"
            "kg"
            "kh"
            "ki"
            "km"
            "kn"
            "kp"
            "kr"
            "kw"
            "ky"
            "kz"
            "l"
            "la"
            "last"
            "later"
            "latter"
            "lb"
            "lc"
            "least"
            "length"
            "less"
            "let"
            "let's"
            "li"
            "like"
            "likely"
            "lk"
            "ll"
            "lr"
            "ls"
            "lt"
            "ltd"
            "lu"
            "lv"
            "ly"
            "m"
            "ma"
            "made"
            "make"
            "makes"
            "many"
            "maybe"
            "mc"
            "md"
            "me"
            "meantime"
            "meanwhile"
            "mg"
            "mh"
            "microsoft"
            "might"
            "mil"
            "million"
            "miss"
            "mk"
            "ml"
            "mm"
            "mn"
            "mo"
            "more"
            "moreover"
            "most"
            "mostly"
            "mp"
            "mq"
            "mr"
            "mrs"
            "ms"
            "msie"
            "mt"
            "mu"
            "much"
            "must"
            "mv"
            "mw"
            "mx"
            "my"
            "myself"
            "mz"
            "n"
            "na"
            "namely"
            "nc"
            "ne"
            "neither"
            "net"
            "netscape"
            "never"
            "nevertheless"
            "new"
            "next"
            "nf"
            "ng"
            "ni"
            "nine"
            "ninety"
            "nl"
            "no"
            "nobody"
            "none"
            "nonetheless"
            "noone"
            "nor"
            "not"
            "nothing"
            "now"
            "nowhere"
            "np"
            "nr"
            "nu"
            "nz"
            "o"
            "of"
            "off"
            "often"
            "om"
            "on"
            "once"
            "one"
            "one's"
            "only"
            "onto"
            "or"
            "org"
            "org"
            "other"
            "others"
            "otherwise"
            "our"
            "ours"
            "ourselves"
            "out"
            "over"
            "overall"
            "own"
            "p"
            "pa"
            "page"
            "pe"
            "per"
            "perhaps"
            "pf"
            "pg"
            "ph"
            "pk"
            "pl"
            "pm"
            "pn"
            "pr"
            "pt"
            "pw"
            "py"
            "q"
            "qa"
            "r"
            "rather"
            "re"
            "recent"
            "recently"
            "reserved"
            "ring"
            "ro"
            "ru"
            "rw"
            "s"
            "sa"
            "same"
            "sb"
            "sc"
            "sd"
            "se"
            "seem"
            "seemed"
            "seeming"
            "seems"
            "seven"
            "seventy"
            "several"
            "sg"
            "sh"
            "she"
            "she'd"
            "she'll"
            "she's"
            "should"
            "shouldn"
            "shouldn't"
            "si"
            "since"
            "site"
            "six"
            "sixty"
            "sj"
            "sk"
            "sl"
            "sm"
            "sn"
            "so"
            "some"
            "somehow"
            "someone"
            "something"
            "sometime"
            "sometimes"
            "somewhere"
            "sr"
            "st"
            "still"
            "stop"
            "su"
            "such"
            "sv"
            "sy"
            "sz"
            "t"
            "taking"
            "tc"
            "td"
            "ten"
            "test"
            "text"
            "tf"
            "tg"
            "th"
            "than"
            "that"
            "that'll"
            "that's"
            "the"
            "their"
            "them"
            "themselves"
            "then"
            "thence"
            "there"
            "there'll"
            "there's"
            "thereafter"
            "thereby"
            "therefore"
            "therein"
            "thereupon"
            "these"
            "they"
            "they'd"
            "they'll"
            "they're"
            "they've"
            "thirty"
            "this"
            "those"
            "though"
            "thousand"
            "three"
            "through"
            "throughout"
            "thru"
            "thus"
            "tj"
            "tk"
            "tm"
            "tn"
            "to"
            "together"
            "too"
            "toward"
            "towards"
            "tp"
            "tr"
            "trillion"
            "tt"
            "tv"
            "tw"
            "twenty"
            "two"
            "tz"
            "u"
            "ua"
            "ug"
            "uk"
            "um"
            "under"
            "unless"
            "unlike"
            "unlikely"
            "until"
            "up"
            "upon"
            "us"
            "use"
            "used"
            "using"
            "uy"
            "uz"
            "v"
            "va"
            "vc"
            "ve"
            "very"
            "vg"
            "vi"
            "via"
            "vn"
            "vu"
            "w"
            "was"
            "wasn"
            "wasn't"
            "we"
            "we'd"
            "we'll"
            "we're"
            "we've"
            "web"
            "webpage"
            "website"
            "welcome"
            "well"
            "were"
            "weren"
            "weren't"
            "wf"
            "what"
            "what'll"
            "what's"
            "whatever"
            "when"
            "whence"
            "whenever"
            "where"
            "whereafter"
            "whereas"
            "whereby"
            "wherein"
            "whereupon"
            "wherever"
            "whether"
            "which"
            "while"
            "whither"
            "who"
            "who'd"
            "who'll"
            "who's"
            "whoever"
            "whole"
            "whom"
            "whomever"
            "whose"
            "why"
            "width"
            "will"
            "with"
            "within"
            "without"
            "won"
            "won't"
            "would"
            "wouldn"
            "wouldn't"
            "ws"
            "www"
            "x"
            "y"
            "ye"
            "yes"
            "yet"
            "you"
            "you'd"
            "you'll"
            "you're"
            "you've"
            "your"
            "yours"
            "yourself"
            "yourselves"
            "yt"
            "yu"
            "z"
            "z"
            "za"
            "zm"
            "zr"
        |]

    let frenchStopWords =
        [|
            "a"
            "accueil"
            "actions"
            "afin"
            "aide"
            "ainsi"
            "aire"
            "aller"
            "allez"
            "alors"
            "an"
            "anmoins"
            "ans"
            "au"
            "aucuns"
            "aujourd"
            "aussi"
            "autre"
            "autres"
            "aux"
            "avaient"
            "avait"
            "avant"
            "avec"
            "avez"
            "avoir"
            "avons"
            "ayant"
            "baisse"
            "bas"
            "base"
            "bien"
            "bon"
            "but"
            "c"
            "car"
            "cas"
            "cause"
            "ce"
            "cela"
            "celle"
            "celles"
            "celui"
            "ces"
            "cet"
            "cette"
            "ceux"
            "chaque"
            "chaud"
            "chercheur"
            "ci"
            "citer"
            "comme"
            "commencer"
            "comment"
            "comprend"
            "connexe"
            "connexes"
            "contenu"
            "contre"
            "correspond"
            "correspondent"
            "d"
            "dans"
            "de"
            "dedans"
            "dehors"
            "depuis"
            "des"
            "deux"
            "devant"
            "devrait"
            "dia"
            "dit"
            "dite"
            "doit"
            "doivent"
            "donc"
            "dont"
            "dos"
            "droite"
            "du"
            "ducatif"
            "ducation"
            "dur"
            "début"
            "e"
            "ecrire"
            "elle"
            "elles"
            "en"
            "encore"
            "enne"
            "entra"
            "entre"
            "environ"
            "er"
            "es"
            "essai"
            "est"
            "et"
            "etc"
            "eu"
            "eux"
            "exemple"
            "exemples"
            "existe"
            "externe"
            "externes"
            "faire"
            "fait"
            "faites"
            "faut"
            "fi"
            "fin"
            "firent"
            "fois"
            "font"
            "force"
            "forme"
            "fr"
            "fut"
            "g"
            "galement"
            "ge"
            "gle"
            "gles"
            "gories"
            "h"
            "haut"
            "hors"
            "hui"
            "i"
            "ici"
            "ii"
            "iii"
            "il"
            "ils"
            "impliquant"
            "j"
            "je"
            "jour"
            "juste"
            "km"
            "kw"
            "l"
            "la"
            "le"
            "les"
            "leur"
            "leurs"
            "liens"
            "lire"
            "lors"
            "lorsque"
            "lu"
            "lus"
            "là"
            "m"
            "ma"
            "maintenant"
            "mais"
            "matiques"
            "me"
            "mes"
            "mettre"
            "milieu"
            "milieux"
            "min"
            "mine"
            "mis"
            "mit"
            "modifier"
            "moin"
            "moins"
            "mon"
            "mot"
            "même"
            "n"
            "ne"
            "nergie"
            "ni"
            "nom"
            "nombre"
            "nommés"
            "non"
            "nos"
            "note"
            "notes"
            "notre"
            "nous"
            "nouveau"
            "nouveaux"
            "o"
            "on"
            "ont"
            "ou"
            "où"
            "p"
            "par"
            "parce"
            "parole"
            "part"
            "partement"
            "partements"
            "partie"
            "pas"
            "permet"
            "permit"
            "personnes"
            "peu"
            "peut"
            "peuvent"
            "pièce"
            "place"
            "plein"
            "plupart"
            "plus"
            "plusieurs"
            "pour"
            "pourquoi"
            "pouvez"
            "pouvons"
            "puissent"
            "q"
            "qu"
            "quand"
            "que"
            "quel"
            "quelle"
            "quelles"
            "quels"
            "qui"
            "quoi"
            "r"
            "rapidement"
            "ration"
            "rature"
            "re"
            "recherche"
            "rechercher"
            "rence"
            "rences"
            "repos"
            "rien"
            "rieures"
            "s"
            "sa"
            "sans"
            "se"
            "sera"
            "ses"
            "seulement"
            "si"
            "sien"
            "son"
            "sont"
            "sous"
            "souvent"
            "soyez"
            "suite"
            "suivez"
            "sujet"
            "sur"
            "t"
            "ta"
            "tandis"
            "tat"
            "tats"
            "te"
            "tellement"
            "tels"
            "tes"
            "tique"
            "tisme"
            "ton"
            "tous"
            "tout"
            "toute"
            "toutes"
            "trois"
            "trop"
            "très"
            "tu"
            "tudiants"
            "tv"
            "u"
            "uer"
            "un"
            "une"
            "utilisation"
            "uvre"
            "v"
            "va"
            "valeur"
            "voie"
            "voient"
            "voir"
            "vont"
            "vos"
            "votre"
            "vous"
            "voyez"
            "vraiment"
            "vu"
            "vue"
            "x"
            "y"
            "ça"
            "étaient"
            "état"
            "étions"
            "été"
            "être"
        |]
