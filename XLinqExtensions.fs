[<AutoOpen>]
module System.Xml.Linq.FSharpExtensions

open System.Runtime.CompilerServices
open System.Xml.Linq

type XNode with
    member this.Ancestors(name) = this.Ancestors(XName.Get name)
    member this.ElementsAfterSelf(name) = this.ElementsAfterSelf(XName.Get name)
    member this.ElementsBeforeSelf(name) = this.ElementsBeforeSelf(XName.Get name)

type XContainer with
    member this.Descendants(name) = this.Descendants(XName.Get name)
    member this.Element(name) = this.Element(XName.Get name)
    member this.Elements(name) = this.Elements(XName.Get name)

type XElement with
    member this.AncestorsAndSelf(name) = this.AncestorsAndSelf(XName.Get name)
    member this.Attribute(name) = this.Attribute(XName.Get name)
    member this.Attributes(name) = this.Attributes(XName.Get name)
    member this.DescendantsAndSelf(name) = this.DescendantsAndSelf(XName.Get name)
    member this.SetAttributeValue(name, value) = this.SetAttributeValue(XName.Get name, value)
    member this.SetElementValue(name, value) = this.SetElementValue(XName.Get name, value)

[<Extension>]
type XLinqSeqExtensions =
    [<Extension>] static member Ancestors(source:seq<#XNode>, name) = source.Ancestors(XName.Get name)
    [<Extension>] static member AncestorsAndSelf(source:seq<XElement>, name) = source.AncestorsAndSelf(XName.Get name)
    [<Extension>] static member Attributes(source:seq<XElement>, name) = source.Attributes(XName.Get name)
    [<Extension>] static member Descendants(source:seq<#XContainer>, name) = source.Descendants(XName.Get name)
    [<Extension>] static member DescendantsAndSelf(source:seq<XElement>, name) = source.DescendantsAndSelf(XName.Get name)
    [<Extension>] static member Elements(source:seq<#XContainer>, name) = source.Elements(XName.Get name)

let XElement(name, content) = new XElement(XName.Get name, Seq.toArray content)
let XAttribute(name, value) = new XAttribute(XName.Get name, value)
