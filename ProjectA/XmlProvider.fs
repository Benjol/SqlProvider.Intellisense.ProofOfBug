//This is just to show that it is not type providers in general that are broken
namespace ProjectA.Xml

open FSharp.Data

type Author = XmlProvider<"""
<samples>
    <author name="Paul Feyerabend" born="1924">
        <height>10</height>
    </author>
    <author name="Karl Popper" born="1902" />
</samples>""", SampleIsList = true>
