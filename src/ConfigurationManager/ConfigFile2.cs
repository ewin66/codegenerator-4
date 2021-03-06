// Copyright 2004, Microsoft Corporation
// Sample Code - Use restricted to terms of use defined in the accompanying license agreement (EULA.doc)

//--------------------------------------------------------------
// Autogenerated by XSDObjectGen version 1.4.4.1
// Schema file: Configuration.xsd
// Creation Date: 5/20/2007 11:46:52 AM
//--------------------------------------------------------------

using System;
using System.Xml.Serialization;
using System.Collections;
using System.Xml.Schema;
using System.ComponentModel;

namespace iCodeGenerator.ConfigurationManager
{

	public struct Declarations
	{
		public const string SchemaVersion = "http://icodegenerator.net/Configuration.xsd";
	}


	[Serializable]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public class SqlTypeCollection : ArrayList
	{
		public SqlType Add(SqlType obj)
		{
			base.Add(obj);
			return obj;
		}

		public SqlType Add()
		{
			return Add(new SqlType());
		}

		public void Insert(int index, SqlType obj)
		{
			base.Insert(index, obj);
		}

		public void Remove(SqlType obj)
		{
			base.Remove(obj);
		}

		new public SqlType this[int index]
		{
			get { return (SqlType) base[index]; }
			set { base[index] = value; }
		}
	}

	[Serializable]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public class DataTypesCollection : ArrayList
	{
		public DataTypes Add(DataTypes obj)
		{
			base.Add(obj);
			return obj;
		}

		public DataTypes Add()
		{
			return Add(new DataTypes());
		}

		public void Insert(int index, DataTypes obj)
		{
			base.Insert(index, obj);
		}

		public void Remove(DataTypes obj)
		{
			base.Remove(obj);
		}

		new public DataTypes this[int index]
		{
			get { return (DataTypes) base[index]; }
			set { base[index] = value; }
		}
	}

	[Serializable]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public class LanguageCollection : ArrayList
	{
		public Language Add(Language obj)
		{
			base.Add(obj);
			return obj;
		}

		public Language Add()
		{
			return Add(new Language());
		}

		public void Insert(int index, Language obj)
		{
			base.Insert(index, obj);
		}

		public void Remove(Language obj)
		{
			base.Remove(obj);
		}

		new public Language this[int index]
		{
			get { return (Language) base[index]; }
			set { base[index] = value; }
		}
	}



	[XmlRoot(ElementName="Configuration",Namespace=Declarations.SchemaVersion,IsNullable=false),Serializable]
	public class Configuration
	{

		[XmlElement(ElementName="StartTag",IsNullable=false,Form=XmlSchemaForm.Qualified,DataType="string",Namespace=Declarations.SchemaVersion)]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public string __StartTag;
		
		[XmlIgnore]
		public string StartTag
		{ 
			get { return __StartTag; }
			set { __StartTag = value; }
		}

		[XmlElement(ElementName="EndTag",IsNullable=false,Form=XmlSchemaForm.Qualified,DataType="string",Namespace=Declarations.SchemaVersion)]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public string __EndTag;
		
		[XmlIgnore]
		public string EndTag
		{ 
			get { return __EndTag; }
			set { __EndTag = value; }
		}

		[XmlElement(Type=typeof(DataTypes),ElementName="DataTypes",IsNullable=false,Form=XmlSchemaForm.Qualified,Namespace=Declarations.SchemaVersion)]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public DataTypesCollection __DataTypesCollection;
		
		[XmlIgnore]
		public DataTypesCollection DataTypesCollection
		{
			get
			{
				if (__DataTypesCollection == null) __DataTypesCollection = new DataTypesCollection();
				return __DataTypesCollection;
			}
			set {__DataTypesCollection = value;}
		}

		public Configuration()
		{
		}

		public void MakeSchemaCompliant()
		{
		}
	}


	[XmlType(TypeName="DataTypes",Namespace=Declarations.SchemaVersion),Serializable]
	public class DataTypes
	{
		[System.Runtime.InteropServices.DispIdAttribute(-4)]
		public IEnumerator GetEnumerator() 
		{
            return LanguageCollection.GetEnumerator();
		}

		public Language Add(Language obj)
		{
			return LanguageCollection.Add(obj);
		}

		[XmlIgnore]
		public Language this[int index]
		{
			get { return (Language) LanguageCollection[index]; }
		}

		[XmlIgnore]
        public int Count 
		{
            get { return LanguageCollection.Count; }
        }

        public void Clear()
		{
			LanguageCollection.Clear();
        }

		public Language Remove(int index) 
		{ 
            Language obj = LanguageCollection[index];
            LanguageCollection.Remove(obj);
			return obj;
        }

        public void Remove(object obj)
		{
            LanguageCollection.Remove(obj);
        }

		[XmlElement(Type=typeof(Language),ElementName="Language",IsNullable=false,Form=XmlSchemaForm.Qualified,Namespace=Declarations.SchemaVersion)]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public LanguageCollection __LanguageCollection;
		
		[XmlIgnore]
		public LanguageCollection LanguageCollection
		{
			get
			{
				if (__LanguageCollection == null) __LanguageCollection = new LanguageCollection();
				return __LanguageCollection;
			}
			set {__LanguageCollection = value;}
		}

		public DataTypes()
		{
		}

		public void MakeSchemaCompliant()
		{
		}
	}


	[XmlType(TypeName="Language",Namespace=Declarations.SchemaVersion),Serializable]
	public class Language
	{
		[System.Runtime.InteropServices.DispIdAttribute(-4)]
		public IEnumerator GetEnumerator() 
		{
            return SqlTypeCollection.GetEnumerator();
		}

		public SqlType Add(SqlType obj)
		{
			return SqlTypeCollection.Add(obj);
		}

		[XmlIgnore]
		public SqlType this[int index]
		{
			get { return (SqlType) SqlTypeCollection[index]; }
		}

		[XmlIgnore]
        public int Count 
		{
            get { return SqlTypeCollection.Count; }
        }

        public void Clear()
		{
			SqlTypeCollection.Clear();
        }

		public SqlType Remove(int index) 
		{ 
            SqlType obj = SqlTypeCollection[index];
            SqlTypeCollection.Remove(obj);
			return obj;
        }

        public void Remove(object obj)
		{
            SqlTypeCollection.Remove(obj);
        }

		[XmlAttribute(AttributeName="name",Form=XmlSchemaForm.Qualified,DataType="string",Namespace=Declarations.SchemaVersion)]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public string __name;
		
		[XmlIgnore]
		public string name
		{ 
			get { return __name; }
			set { __name = value; }
		}

		[XmlAttribute(AttributeName="selected",Form=XmlSchemaForm.Qualified,DataType="string",Namespace=Declarations.SchemaVersion)]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public string __selected;
		
		[XmlIgnore]
		public string selected
		{ 
			get { return __selected; }
			set { __selected = value; }
		}

		[XmlElement(Type=typeof(SqlType),ElementName="SqlType",IsNullable=true,Form=XmlSchemaForm.Qualified,Namespace=Declarations.SchemaVersion)]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public SqlTypeCollection __SqlTypeCollection;
		
		[XmlIgnore]
		public SqlTypeCollection SqlTypeCollection
		{
			get
			{
				if (__SqlTypeCollection == null) __SqlTypeCollection = new SqlTypeCollection();
				return __SqlTypeCollection;
			}
			set {__SqlTypeCollection = value;}
		}

		public Language()
		{
		}

		public void MakeSchemaCompliant()
		{
		}
	}


	[XmlType(TypeName="SqlType",Namespace=Declarations.SchemaVersion),Serializable]
	public class SqlType
	{

		[XmlAttribute(AttributeName="name",Form=XmlSchemaForm.Qualified,DataType="string",Namespace=Declarations.SchemaVersion)]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public string __name;
		
		[XmlIgnore]
		public string name
		{ 
			get { return __name; }
			set { __name = value; }
		}

		[XmlText(DataType="string")]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public string __Value;
		
		[XmlIgnore]
		public string Value
		{ 
			get { return __Value; }
			set { __Value = value; }
		}

		public SqlType()
		{
		}

		public void MakeSchemaCompliant()
		{
		}
	}
}
