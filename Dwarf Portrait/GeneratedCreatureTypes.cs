﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dwarf_Portrait
{
    public class GeneratedCreatureType
    {
        public enum CreatureType
        {
            Blob,
            Quadruped,
            Humanoid,
            Silverfish,
            Mayfly,
            Dragonfly,
            Damselfly,
            Stonefly,
            Earwig,
            Grasshopper,
            Cricket,
            StickInsect,
            Cockroach,
            Termite,
            Mantis,
            Louse,
            Thrips,
            Aphid,
            Cicada,
            AssassinBug,
            Wasp,
            Hornet,
            TigerBeetle,
            Ladybug,
            Weevil,
            DarklingBeetle,
            ClickBeetle,
            Firefly,
            ScarabBeetle,
            StagBeetle,
            DungBeetle,
            RhinocerosBeetle,
            RoveBeetle,
            Snakefly,
            Lacewing,
            AntlionLarva,
            Mosquito,
            Flea,
            Scorpionfly,
            Caddisfly,
            Butterfly,
            Moth,
            Caterpillar,
            Maggot,
            Spider,
            Tarantula,
            Scorpion,
            Tick,
            Mite,
            Shrimp,
            Lobster,
            Crab,
            Nematode,
            Snail,
            Slug,
            Earthworm,
            Leech,
            Bristleworm,
            RibbonWorm,
            FlatWorm,
            Toad,
            Frog,
            Salamander,
            Newt,
            Alligator,
            Crocodile,
            Lizard,
            Chameleon,
            Iguana,
            Gecko,
            Skink,
            GilaMonster,
            Monitor,
            Serpent,
            Viper,
            Rattlesnake,
            Cobra,
            Python,
            Anaconda,
            Turtle,
            Tortoise,
            Pterosaur,
            Dimetrodon,
            Sauropod,
            Theropod,
            Iguanodont,
            Hadrosaurid,
            Stegosaurid,
            Ceratopsid,
            Ankylosaurid,
            Duck,
            Goose,
            Swan,
            Turkey,
            Grouse,
            Chicken,
            Quail,
            Pheasant,
            Gull,
            Loon,
            Grebe,
            Albatross,
            Petrel,
            Penguin,
            Pelican,
            Stork,
            Vulture,
            Flamingo,
            Falcon,
            Kestrel,
            Condor,
            Osprey,
            Buzzard,
            Eagle,
            Harrier,
            Kite,
            Crane,
            Dove,
            Pigeon,
            Parrot,
            Cockatoo,
            Cuckoo,
            Nightjar,
            Swift,
            Hummingbird,
            Kingfisher,
            Hornbill,
            Quetzal,
            Toucan,
            Woodpecker,
            Lyrebird,
            Thornbill,
            Honeyeater,
            Oriole,
            Fantail,
            Shrike,
            Crow,
            Raven,
            Magpie,
            Kinglet,
            Lark,
            Swallow,
            Martin,
            Bushtit,
            Warbler,
            Thrush,
            Oxpecker,
            Starling,
            Mockingbird,
            Wren,
            Nuthatch,
            Sparrow,
            Tanager,
            Cardinal,
            Bunting,
            Finch,
            Titmouse,
            Chickadee,
            Waxwing,
            Flycatcher,
            Opossum,
            Koala,
            Wombat,
            Kangaroo,
            Sloth,
            Anteater,
            Armadillo,
            Squirrel,
            Marmot,
            Beaver,
            Gopher,
            Mouse,
            Porcupine,
            Chinchilla,
            Cavy,
            Capybara,
            Rabbit,
            Hare,
            Lemur,
            Loris,
            Monkey,
            Hedgehog,
            Shrew,
            Mole,
            FruitBat,
            Wolf,
            Coyote,
            Jackal,
            Raccoon,
            Coati,
            Weasel,
            Otter,
            Badger,
            Skunk,
            Bear,
            Panda,
            Panther,
            Mongoose,
            Hyena,
            Civet,
            Walrus,
            Pangolin,
            Elephant,
            Mammoth,
            Horse,
            Zebra,
            Tapir,
            Rhinoceros,
            Warthog,
            Hippopotamus,
            Camel,
            Llama,
            Giraffe,
            Deer,
            Moose,
            Antelope,
            Sheep,
            Goat,
            Bison,
            Buffalo,
            Bull
        }

        public static readonly Dictionary<CreatureType, string> creatureStrings = new Dictionary<CreatureType, string>
        {
            { CreatureType.Blob, "blob" },
            { CreatureType.Quadruped, "quadruped" },
            { CreatureType.Humanoid, "humanoid" },
            { CreatureType.Silverfish, "silverfish" },
            { CreatureType.Mayfly, "mayfly" },
            { CreatureType.Dragonfly, "dragonfly" },
            { CreatureType.Damselfly, "damselfly" },
            { CreatureType.Stonefly, "stonefly" },
            { CreatureType.Earwig, "earwig" },
            { CreatureType.Grasshopper, "grasshopper" },
            { CreatureType.Cricket, "cricket" },
            { CreatureType.StickInsect, "stickinsect" },
            { CreatureType.Cockroach, "cockroach" },
            { CreatureType.Termite, "termite" },
            { CreatureType.Mantis, "mantis" },
            { CreatureType.Louse, "louse" },
            { CreatureType.Thrips, "thrips" },
            { CreatureType.Aphid, "aphid" },
            { CreatureType.Cicada, "cicada" },
            { CreatureType.AssassinBug, "assassinbug" },
            { CreatureType.Wasp, "wasp" },
            { CreatureType.Hornet, "hornet" },
            { CreatureType.TigerBeetle, "tigerbeetle" },
            { CreatureType.Ladybug, "ladybug" },
            { CreatureType.Weevil, "weevil" },
            { CreatureType.DarklingBeetle, "darklingbeetle" },
            { CreatureType.ClickBeetle, "clickbeetle" },
            { CreatureType.Firefly, "firefly" },
            { CreatureType.ScarabBeetle, "scarabbeetle" },
            { CreatureType.StagBeetle, "stagbeetle" },
            { CreatureType.DungBeetle, "dungbeetle" },
            { CreatureType.RhinocerosBeetle, "rhinocerosbeetle" },
            { CreatureType.RoveBeetle, "rovebeetle" },
            { CreatureType.Snakefly, "snakefly" },
            { CreatureType.Lacewing, "lacewing" },
            { CreatureType.AntlionLarva, "antlionlarva" },
            { CreatureType.Mosquito, "mosquito" },
            { CreatureType.Flea, "flea" },
            { CreatureType.Scorpionfly, "scorpionfly" },
            { CreatureType.Caddisfly, "caddisfly" },
            { CreatureType.Butterfly, "butterfly" },
            { CreatureType.Moth, "moth" },
            { CreatureType.Caterpillar, "caterpillar" },
            { CreatureType.Maggot, "maggot" },
            { CreatureType.Spider, "spider" },
            { CreatureType.Tarantula, "tarantula" },
            { CreatureType.Scorpion, "scorpion" },
            { CreatureType.Tick, "tick" },
            { CreatureType.Mite, "mite" },
            { CreatureType.Shrimp, "shrimp" },
            { CreatureType.Lobster, "lobster" },
            { CreatureType.Crab, "crab" },
            { CreatureType.Nematode, "nematode" },
            { CreatureType.Snail, "snail" },
            { CreatureType.Slug, "slug" },
            { CreatureType.Earthworm, "earthworm" },
            { CreatureType.Leech, "leech" },
            { CreatureType.Bristleworm, "bristleworm" },
            { CreatureType.RibbonWorm, "ribbonworm" },
            { CreatureType.FlatWorm, "flatworm" },
            { CreatureType.Toad, "toad" },
            { CreatureType.Frog, "frog" },
            { CreatureType.Salamander, "salamander" },
            { CreatureType.Newt, "newt" },
            { CreatureType.Alligator, "alligator" },
            { CreatureType.Crocodile, "crocodile" },
            { CreatureType.Lizard, "lizard" },
            { CreatureType.Chameleon, "chameleon" },
            { CreatureType.Iguana, "iguana" },
            { CreatureType.Gecko, "gecko" },
            { CreatureType.Skink, "skink" },
            { CreatureType.GilaMonster, "gilamonster" },
            { CreatureType.Monitor, "monitor" },
            { CreatureType.Serpent, "serpent" },
            { CreatureType.Viper, "viper" },
            { CreatureType.Rattlesnake, "rattlesnake" },
            { CreatureType.Cobra, "cobra" },
            { CreatureType.Python, "python" },
            { CreatureType.Anaconda, "anaconda" },
            { CreatureType.Turtle, "turtle" },
            { CreatureType.Tortoise, "tortoise" },
            { CreatureType.Pterosaur, "pterosaur" },
            { CreatureType.Dimetrodon, "dimetrodon" },
            { CreatureType.Sauropod, "sauropod" },
            { CreatureType.Theropod, "theropod" },
            { CreatureType.Iguanodont, "iguanodont" },
            { CreatureType.Hadrosaurid, "hadrosaurid" },
            { CreatureType.Stegosaurid, "stegosaurid" },
            { CreatureType.Ceratopsid, "ceratopsid" },
            { CreatureType.Ankylosaurid, "ankylosaurid" },
            { CreatureType.Duck, "duck" },
            { CreatureType.Goose, "goose" },
            { CreatureType.Swan, "swan" },
            { CreatureType.Turkey, "turkey" },
            { CreatureType.Grouse, "grouse" },
            { CreatureType.Chicken, "chicken" },
            { CreatureType.Quail, "quail" },
            { CreatureType.Pheasant, "pheasant" },
            { CreatureType.Gull, "gull" },
            { CreatureType.Loon, "loon" },
            { CreatureType.Grebe, "grebe" },
            { CreatureType.Albatross, "albatross" },
            { CreatureType.Petrel, "petrel" },
            { CreatureType.Penguin, "penguin" },
            { CreatureType.Pelican, "pelican" },
            { CreatureType.Stork, "stork" },
            { CreatureType.Vulture, "vulture" },
            { CreatureType.Flamingo, "flamingo" },
            { CreatureType.Falcon, "falcon" },
            { CreatureType.Kestrel, "kestrel" },
            { CreatureType.Condor, "condor" },
            { CreatureType.Osprey, "osprey" },
            { CreatureType.Buzzard, "buzzard" },
            { CreatureType.Eagle, "eagle" },
            { CreatureType.Harrier, "harrier" },
            { CreatureType.Kite, "kite" },
            { CreatureType.Crane, "crane" },
            { CreatureType.Dove, "dove" },
            { CreatureType.Pigeon, "pigeon" },
            { CreatureType.Parrot, "parrot" },
            { CreatureType.Cockatoo, "cockatoo" },
            { CreatureType.Cuckoo, "cuckoo" },
            { CreatureType.Nightjar, "nightjar" },
            { CreatureType.Swift, "swift" },
            { CreatureType.Hummingbird, "hummingbird" },
            { CreatureType.Kingfisher, "kingfisher" },
            { CreatureType.Hornbill, "hornbill" },
            { CreatureType.Quetzal, "quetzal" },
            { CreatureType.Toucan, "toucan" },
            { CreatureType.Woodpecker, "woodpecker" },
            { CreatureType.Lyrebird, "lyrebird" },
            { CreatureType.Thornbill, "thornbill" },
            { CreatureType.Honeyeater, "honeyeater" },
            { CreatureType.Oriole, "oriole" },
            { CreatureType.Fantail, "fantail" },
            { CreatureType.Shrike, "shrike" },
            { CreatureType.Crow, "crow" },
            { CreatureType.Raven, "raven" },
            { CreatureType.Magpie, "magpie" },
            { CreatureType.Kinglet, "kinglet" },
            { CreatureType.Lark, "lark" },
            { CreatureType.Swallow, "swallow" },
            { CreatureType.Martin, "martin" },
            { CreatureType.Bushtit, "bushtit" },
            { CreatureType.Warbler, "warbler" },
            { CreatureType.Thrush, "thrush" },
            { CreatureType.Oxpecker, "oxpecker" },
            { CreatureType.Starling, "starling" },
            { CreatureType.Mockingbird, "mockingbird" },
            { CreatureType.Wren, "wren" },
            { CreatureType.Nuthatch, "nuthatch" },
            { CreatureType.Sparrow, "sparrow" },
            { CreatureType.Tanager, "tanager" },
            { CreatureType.Cardinal, "cardinal" },
            { CreatureType.Bunting, "bunting" },
            { CreatureType.Finch, "finch" },
            { CreatureType.Titmouse, "titmouse" },
            { CreatureType.Chickadee, "chickadee" },
            { CreatureType.Waxwing, "waxwing" },
            { CreatureType.Flycatcher, "flycatcher" },
            { CreatureType.Opossum, "opossum" },
            { CreatureType.Koala, "koala" },
            { CreatureType.Wombat, "wombat" },
            { CreatureType.Kangaroo, "kangaroo" },
            { CreatureType.Sloth, "sloth" },
            { CreatureType.Anteater, "anteater" },
            { CreatureType.Armadillo, "armadillo" },
            { CreatureType.Squirrel, "squirrel" },
            { CreatureType.Marmot, "marmot" },
            { CreatureType.Beaver, "beaver" },
            { CreatureType.Gopher, "gopher" },
            { CreatureType.Mouse, "mouse" },
            { CreatureType.Porcupine, "porcupine" },
            { CreatureType.Chinchilla, "chinchilla" },
            { CreatureType.Cavy, "cavy" },
            { CreatureType.Capybara, "capybara" },
            { CreatureType.Rabbit, "rabbit" },
            { CreatureType.Hare, "hare" },
            { CreatureType.Lemur, "lemur" },
            { CreatureType.Loris, "loris" },
            { CreatureType.Monkey, "monkey" },
            { CreatureType.Hedgehog, "hedgehog" },
            { CreatureType.Shrew, "shrew" },
            { CreatureType.Mole, "mole" },
            { CreatureType.FruitBat, "fruitbat" },
            { CreatureType.Wolf, "wolf" },
            { CreatureType.Coyote, "coyote" },
            { CreatureType.Jackal, "jackal" },
            { CreatureType.Raccoon, "raccoon" },
            { CreatureType.Coati, "coati" },
            { CreatureType.Weasel, "weasel" },
            { CreatureType.Otter, "otter" },
            { CreatureType.Badger, "badger" },
            { CreatureType.Skunk, "skunk" },
            { CreatureType.Bear, "bear" },
            { CreatureType.Panda, "panda" },
            { CreatureType.Panther, "panther" },
            { CreatureType.Mongoose, "mongoose" },
            { CreatureType.Hyena, "hyena" },
            { CreatureType.Civet, "civet" },
            { CreatureType.Walrus, "walrus" },
            { CreatureType.Pangolin, "pangolin" },
            { CreatureType.Elephant, "elephant" },
            { CreatureType.Mammoth, "mammoth" },
            { CreatureType.Horse, "horse" },
            { CreatureType.Zebra, "zebra" },
            { CreatureType.Tapir, "tapir" },
            { CreatureType.Rhinoceros, "rhinoceros" },
            { CreatureType.Warthog, "warthog" },
            { CreatureType.Hippopotamus, "hippopotamus" },
            { CreatureType.Camel, "camel" },
            { CreatureType.Llama, "llama" },
            { CreatureType.Giraffe, "giraffe" },
            { CreatureType.Deer, "deer" },
            { CreatureType.Moose, "moose" },
            { CreatureType.Antelope, "antelope" },
            { CreatureType.Sheep, "sheep" },
            { CreatureType.Goat, "goat" },
            { CreatureType.Bison, "bison" },
            { CreatureType.Buffalo, "buffalo" },
            { CreatureType.Bull, "bull" }
        };
    }
}
