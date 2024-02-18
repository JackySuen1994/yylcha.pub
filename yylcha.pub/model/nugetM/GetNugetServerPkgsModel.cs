using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace yylcha.pub.model.nugetM
{
    [XmlRoot(ElementName = "title", Namespace = "http://www.w3.org/2005/Atom")]
    public class Title
    {
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "link", Namespace = "http://www.w3.org/2005/Atom")]
    public class Link
    {
        [XmlAttribute(AttributeName = "rel")]
        public string Rel { get; set; }
        [XmlAttribute(AttributeName = "title")]
        public string Title { get; set; }
        [XmlAttribute(AttributeName = "href")]
        public string Href { get; set; }
    }

    [XmlRoot(ElementName = "summary", Namespace = "http://www.w3.org/2005/Atom")]
    public class Summary
    {
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
    }

    [XmlRoot(ElementName = "author", Namespace = "http://www.w3.org/2005/Atom")]
    public class Author
    {
        [XmlElement(ElementName = "name", Namespace = "http://www.w3.org/2005/Atom")]
        public string Name { get; set; }
    }

    [XmlRoot(ElementName = "category", Namespace = "http://www.w3.org/2005/Atom")]
    public class Category
    {
        [XmlAttribute(AttributeName = "term")]
        public string Term { get; set; }
        [XmlAttribute(AttributeName = "scheme")]
        public string Scheme { get; set; }
    }

    [XmlRoot(ElementName = "content", Namespace = "http://www.w3.org/2005/Atom")]
    public class Content
    {
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
        [XmlAttribute(AttributeName = "src")]
        public string Src { get; set; }
    }

    [XmlRoot(ElementName = "IsPrerelease", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    public class IsPrerelease
    {
        [XmlAttribute(AttributeName = "type", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
        public string Type { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "IconUrl", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    public class IconUrl
    {
        [XmlAttribute(AttributeName = "null", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
        public string Null { get; set; }
    }

    [XmlRoot(ElementName = "LicenseUrl", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    public class LicenseUrl
    {
        [XmlAttribute(AttributeName = "null", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
        public string Null { get; set; }
    }

    [XmlRoot(ElementName = "ProjectUrl", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    public class ProjectUrl
    {
        [XmlAttribute(AttributeName = "null", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
        public string Null { get; set; }
    }

    [XmlRoot(ElementName = "DownloadCount", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    public class DownloadCount
    {
        [XmlAttribute(AttributeName = "type", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
        public string Type { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "RequireLicenseAcceptance", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    public class RequireLicenseAcceptance
    {
        [XmlAttribute(AttributeName = "type", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
        public string Type { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "DevelopmentDependency", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    public class DevelopmentDependency
    {
        [XmlAttribute(AttributeName = "type", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
        public string Type { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "ReleaseNotes", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    public class ReleaseNotes
    {
        [XmlAttribute(AttributeName = "null", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
        public string Null { get; set; }
    }

    [XmlRoot(ElementName = "Published", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    public class Published
    {
        [XmlAttribute(AttributeName = "type", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
        public string Type { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "PackageSize", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    public class PackageSize
    {
        [XmlAttribute(AttributeName = "type", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
        public string Type { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Copyright", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    public class Copyright
    {
        [XmlAttribute(AttributeName = "null", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
        public string Null { get; set; }
    }

    [XmlRoot(ElementName = "Tags", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    public class Tags
    {
        [XmlAttribute(AttributeName = "null", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
        public string Null { get; set; }
    }

    [XmlRoot(ElementName = "IsAbsoluteLatestVersion", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    public class IsAbsoluteLatestVersion
    {
        [XmlAttribute(AttributeName = "type", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
        public string Type { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "IsLatestVersion", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    public class IsLatestVersion
    {
        [XmlAttribute(AttributeName = "type", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
        public string Type { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Listed", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    public class Listed
    {
        [XmlAttribute(AttributeName = "type", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
        public string Type { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "VersionDownloadCount", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    public class VersionDownloadCount
    {
        [XmlAttribute(AttributeName = "type", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
        public string Type { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "MinClientVersion", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    public class MinClientVersion
    {
        [XmlAttribute(AttributeName = "null", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
        public string Null { get; set; }
    }

    [XmlRoot(ElementName = "properties", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
    public class Properties
    {
        [XmlElement(ElementName = "Version", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
        public string Version { get; set; }
        [XmlElement(ElementName = "IsPrerelease", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
        public IsPrerelease IsPrerelease { get; set; }
        [XmlElement(ElementName = "Title", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
        public Title Title { get; set; }
        [XmlElement(ElementName = "Owners", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
        public string Owners { get; set; }
        [XmlElement(ElementName = "IconUrl", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
        public IconUrl IconUrl { get; set; }
        [XmlElement(ElementName = "LicenseUrl", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
        public LicenseUrl LicenseUrl { get; set; }
        [XmlElement(ElementName = "ProjectUrl", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
        public ProjectUrl ProjectUrl { get; set; }
        [XmlElement(ElementName = "DownloadCount", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
        public DownloadCount DownloadCount { get; set; }
        [XmlElement(ElementName = "RequireLicenseAcceptance", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
        public RequireLicenseAcceptance RequireLicenseAcceptance { get; set; }
        [XmlElement(ElementName = "DevelopmentDependency", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
        public DevelopmentDependency DevelopmentDependency { get; set; }
        [XmlElement(ElementName = "Description", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
        public string Description { get; set; }
        [XmlElement(ElementName = "ReleaseNotes", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
        public ReleaseNotes ReleaseNotes { get; set; }
        [XmlElement(ElementName = "Published", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
        public Published Published { get; set; }
        [XmlElement(ElementName = "Dependencies", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
        public string Dependencies { get; set; }
        [XmlElement(ElementName = "PackageHash", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
        public string PackageHash { get; set; }
        [XmlElement(ElementName = "PackageHashAlgorithm", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
        public string PackageHashAlgorithm { get; set; }
        [XmlElement(ElementName = "PackageSize", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
        public PackageSize PackageSize { get; set; }
        [XmlElement(ElementName = "Copyright", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
        public Copyright Copyright { get; set; }
        [XmlElement(ElementName = "Tags", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
        public Tags Tags { get; set; }
        [XmlElement(ElementName = "IsAbsoluteLatestVersion", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
        public IsAbsoluteLatestVersion IsAbsoluteLatestVersion { get; set; }
        [XmlElement(ElementName = "IsLatestVersion", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
        public IsLatestVersion IsLatestVersion { get; set; }
        [XmlElement(ElementName = "Listed", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
        public Listed Listed { get; set; }
        [XmlElement(ElementName = "VersionDownloadCount", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
        public VersionDownloadCount VersionDownloadCount { get; set; }
        [XmlElement(ElementName = "MinClientVersion", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
        public MinClientVersion MinClientVersion { get; set; }
        [XmlElement(ElementName = "Summary", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
        public Summary Summary { get; set; }
        [XmlAttribute(AttributeName = "m", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string M { get; set; }
        [XmlAttribute(AttributeName = "d", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string D { get; set; }
    }

    [XmlRoot(ElementName = "entry", Namespace = "http://www.w3.org/2005/Atom")]
    public class Entry
    {
        [XmlElement(ElementName = "id", Namespace = "http://www.w3.org/2005/Atom")]
        public string Id { get; set; }
        [XmlElement(ElementName = "title", Namespace = "http://www.w3.org/2005/Atom")]
        public Title Title { get; set; }
        [XmlElement(ElementName = "summary", Namespace = "http://www.w3.org/2005/Atom")]
        public Summary Summary { get; set; }
        [XmlElement(ElementName = "updated", Namespace = "http://www.w3.org/2005/Atom")]
        public string Updated { get; set; }
        [XmlElement(ElementName = "author", Namespace = "http://www.w3.org/2005/Atom")]
        public Author Author { get; set; }
        [XmlElement(ElementName = "link", Namespace = "http://www.w3.org/2005/Atom")]
        public List<Link> Link { get; set; }
        [XmlElement(ElementName = "category", Namespace = "http://www.w3.org/2005/Atom")]
        public Category Category { get; set; }
        [XmlElement(ElementName = "content", Namespace = "http://www.w3.org/2005/Atom")]
        public Content Content { get; set; }
        [XmlElement(ElementName = "properties", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
        public Properties Properties { get; set; }
    }

    [XmlRoot(ElementName = "feed", Namespace = "http://www.w3.org/2005/Atom")]
    public class Feed
    {
        [XmlElement(ElementName = "title", Namespace = "http://www.w3.org/2005/Atom")]
        public Title Title { get; set; }
        [XmlElement(ElementName = "id", Namespace = "http://www.w3.org/2005/Atom")]
        public string Id { get; set; }
        [XmlElement(ElementName = "updated", Namespace = "http://www.w3.org/2005/Atom")]
        public string Updated { get; set; }
        [XmlElement(ElementName = "link", Namespace = "http://www.w3.org/2005/Atom")]
        public List<Link> Link { get; set; }
        [XmlElement(ElementName = "entry", Namespace = "http://www.w3.org/2005/Atom")]
        public List<Entry> Entry { get; set; }
        [XmlAttribute(AttributeName = "base", Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string Base { get; set; }
        [XmlAttribute(AttributeName = "d", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string D { get; set; }
        [XmlAttribute(AttributeName = "m", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string M { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
    }
}
