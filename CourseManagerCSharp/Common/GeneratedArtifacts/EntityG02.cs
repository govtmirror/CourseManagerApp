

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LightSwitchApplication
{
    #region Entities
    
    /// <summary>
    /// No Modeled Description Available
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
    public sealed partial class Course : global::Microsoft.LightSwitch.Framework.Base.EntityObject<global::LightSwitchApplication.Course, global::LightSwitchApplication.Course.DetailsClass>
    {
        #region Constructors
    
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public Course()
            : this(null)
        {
        }
    
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public Course(global::Microsoft.LightSwitch.Framework.EntitySet<global::LightSwitchApplication.Course> entitySet)
            : base(entitySet)
        {
            global::LightSwitchApplication.Course.DetailsClass.Initialize(this);
        }
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Course_Created();
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Course_AllowSaveWithErrors(ref bool result);
    
        #endregion
    
        #region Private Properties
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::Microsoft.LightSwitch.IApplication<global::LightSwitchApplication.DataWorkspace> Application
        {
            get
            {
                return global::LightSwitchApplication.Application.Current;
            }
        }
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::LightSwitchApplication.DataWorkspace DataWorkspace
        {
            get
            {
                return (global::LightSwitchApplication.DataWorkspace)this.Details.EntitySet.Details.DataService.Details.DataWorkspace;
            }
        }
        
        #endregion
    
        #region Public Properties
    
        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public int Id
        {
            get
            {
                return global::LightSwitchApplication.Course.DetailsClass.GetValue(this, global::LightSwitchApplication.Course.DetailsClass.PropertySetProperties.Id);
            }
            set
            {
                global::LightSwitchApplication.Course.DetailsClass.SetValue(this, global::LightSwitchApplication.Course.DetailsClass.PropertySetProperties.Id, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Id_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Id_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Id_Changed();

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public string Title
        {
            get
            {
                return global::LightSwitchApplication.Course.DetailsClass.GetValue(this, global::LightSwitchApplication.Course.DetailsClass.PropertySetProperties.Title);
            }
            set
            {
                global::LightSwitchApplication.Course.DetailsClass.SetValue(this, global::LightSwitchApplication.Course.DetailsClass.PropertySetProperties.Title, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Title_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Title_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Title_Changed();

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public string Description
        {
            get
            {
                return global::LightSwitchApplication.Course.DetailsClass.GetValue(this, global::LightSwitchApplication.Course.DetailsClass.PropertySetProperties.Description);
            }
            set
            {
                global::LightSwitchApplication.Course.DetailsClass.SetValue(this, global::LightSwitchApplication.Course.DetailsClass.PropertySetProperties.Description, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Description_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Description_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Description_Changed();

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Microsoft.LightSwitch.Framework.EntityCollection<global::LightSwitchApplication.Section> Sections
        {
            get
            {
                return global::LightSwitchApplication.Course.DetailsClass.GetValue(this, global::LightSwitchApplication.Course.DetailsClass.PropertySetProperties.Sections);
            }
        }
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public Microsoft.LightSwitch.IDataServiceQueryable<global::LightSwitchApplication.Section> SectionsQuery
        {
            get
            {
                return global::LightSwitchApplication.Course.DetailsClass.GetQuery(this, global::LightSwitchApplication.Course.DetailsClass.PropertySetProperties.Sections);
            }
        }

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Microsoft.LightSwitch.Framework.EntityCollection<global::LightSwitchApplication.CourseCategory> CourseCategories
        {
            get
            {
                return global::LightSwitchApplication.Course.DetailsClass.GetValue(this, global::LightSwitchApplication.Course.DetailsClass.PropertySetProperties.CourseCategories);
            }
        }
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public Microsoft.LightSwitch.IDataServiceQueryable<global::LightSwitchApplication.CourseCategory> CourseCategoriesQuery
        {
            get
            {
                return global::LightSwitchApplication.Course.DetailsClass.GetQuery(this, global::LightSwitchApplication.Course.DetailsClass.PropertySetProperties.CourseCategories);
            }
        }

        #endregion
    
        #region Details Class
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public sealed class DetailsClass : global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<
                global::LightSwitchApplication.Course,
                global::LightSwitchApplication.Course.DetailsClass,
                global::LightSwitchApplication.Course.DetailsClass.IImplementation,
                global::LightSwitchApplication.Course.DetailsClass.PropertySet,
                global::Microsoft.LightSwitch.Details.Framework.EntityCommandSet<global::LightSwitchApplication.Course, global::LightSwitchApplication.Course.DetailsClass>,
                global::Microsoft.LightSwitch.Details.Framework.EntityMethodSet<global::LightSwitchApplication.Course, global::LightSwitchApplication.Course.DetailsClass>>
        {
    
            static DetailsClass()
            {
                var initializeEntry = global::LightSwitchApplication.Course.DetailsClass.PropertySetProperties.Id;
            }
    
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private static readonly global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<global::LightSwitchApplication.Course, global::LightSwitchApplication.Course.DetailsClass>.Entry
                __CourseEntry = new global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<global::LightSwitchApplication.Course, global::LightSwitchApplication.Course.DetailsClass>.Entry(
                    global::LightSwitchApplication.Course.DetailsClass.__Course_CreateNew,
                    global::LightSwitchApplication.Course.DetailsClass.__Course_Created,
                    global::LightSwitchApplication.Course.DetailsClass.__Course_AllowSaveWithErrors);
            private static global::LightSwitchApplication.Course __Course_CreateNew(global::Microsoft.LightSwitch.Framework.EntitySet<global::LightSwitchApplication.Course> es)
            {
                return new global::LightSwitchApplication.Course(es);
            }
            private static void __Course_Created(global::LightSwitchApplication.Course e)
            {
                e.Course_Created();
            }
            private static bool __Course_AllowSaveWithErrors(global::LightSwitchApplication.Course e)
            {
                bool result = false;
                e.Course_AllowSaveWithErrors(ref result);
                return result;
            }
    
            public DetailsClass() : base()
            {
            }
    
            public new global::Microsoft.LightSwitch.Details.Framework.EntityCommandSet<global::LightSwitchApplication.Course, global::LightSwitchApplication.Course.DetailsClass> Commands
            {
                get
                {
                    return base.Commands;
                }
            }
    
            public new global::Microsoft.LightSwitch.Details.Framework.EntityMethodSet<global::LightSwitchApplication.Course, global::LightSwitchApplication.Course.DetailsClass> Methods
            {
                get
                {
                    return base.Methods;
                }
            }
    
            public new global::LightSwitchApplication.Course.DetailsClass.PropertySet Properties
            {
                get
                {
                    return base.Properties;
                }
            }
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public sealed class PropertySet : global::Microsoft.LightSwitch.Details.Framework.Base.EntityPropertySet<global::LightSwitchApplication.Course, global::LightSwitchApplication.Course.DetailsClass>
            {
    
                public PropertySet() : base()
                {
                }
    
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Course, global::LightSwitchApplication.Course.DetailsClass, int> Id
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Course.DetailsClass.PropertySetProperties.Id) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Course, global::LightSwitchApplication.Course.DetailsClass, int>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Course, global::LightSwitchApplication.Course.DetailsClass, string> Title
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Course.DetailsClass.PropertySetProperties.Title) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Course, global::LightSwitchApplication.Course.DetailsClass, string>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Course, global::LightSwitchApplication.Course.DetailsClass, string> Description
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Course.DetailsClass.PropertySetProperties.Description) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Course, global::LightSwitchApplication.Course.DetailsClass, string>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Course, global::LightSwitchApplication.Course.DetailsClass, global::LightSwitchApplication.Section> Sections
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Course.DetailsClass.PropertySetProperties.Sections) as global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Course, global::LightSwitchApplication.Course.DetailsClass, global::LightSwitchApplication.Section>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Course, global::LightSwitchApplication.Course.DetailsClass, global::LightSwitchApplication.CourseCategory> CourseCategories
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Course.DetailsClass.PropertySetProperties.CourseCategories) as global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Course, global::LightSwitchApplication.Course.DetailsClass, global::LightSwitchApplication.CourseCategory>;
                    }
                }
                
            }
    
            #pragma warning disable 109
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
            public interface IImplementation : global::Microsoft.LightSwitch.Internal.IEntityImplementation
            {
                new int Id { get; set; }
                new string Title { get; set; }
                new string Description { get; set; }
                new global::System.Collections.IEnumerable Sections { get; }
                new global::System.Collections.IEnumerable CourseCategories { get; }
            }
            #pragma warning restore 109
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal class PropertySetProperties
            {
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Course, global::LightSwitchApplication.Course.DetailsClass, int>.Entry
                    Id = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Course, global::LightSwitchApplication.Course.DetailsClass, int>.Entry(
                        "Id",
                        global::LightSwitchApplication.Course.DetailsClass.PropertySetProperties._Id_Stub,
                        global::LightSwitchApplication.Course.DetailsClass.PropertySetProperties._Id_ComputeIsReadOnly,
                        global::LightSwitchApplication.Course.DetailsClass.PropertySetProperties._Id_Validate,
                        global::LightSwitchApplication.Course.DetailsClass.PropertySetProperties._Id_GetImplementationValue,
                        global::LightSwitchApplication.Course.DetailsClass.PropertySetProperties._Id_SetImplementationValue,
                        global::LightSwitchApplication.Course.DetailsClass.PropertySetProperties._Id_OnValueChanged);
                private static void _Id_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Course.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Course, global::LightSwitchApplication.Course.DetailsClass, int>.Data> c, global::LightSwitchApplication.Course.DetailsClass d, object sf)
                {
                    c(d, ref d._Id, sf);
                }
                private static bool _Id_ComputeIsReadOnly(global::LightSwitchApplication.Course e)
                {
                    bool result = false;
                    e.Id_IsReadOnly(ref result);
                    return result;
                }
                private static void _Id_Validate(global::LightSwitchApplication.Course e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.Id_Validate(r);
                }
                private static int _Id_GetImplementationValue(global::LightSwitchApplication.Course.DetailsClass d)
                {
                    return d.ImplementationEntity.Id;
                }
                private static void _Id_SetImplementationValue(global::LightSwitchApplication.Course.DetailsClass d, int v)
                {
                    d.ImplementationEntity.Id = v;
                }
                private static void _Id_OnValueChanged(global::LightSwitchApplication.Course e)
                {
                    e.Id_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Course, global::LightSwitchApplication.Course.DetailsClass, string>.Entry
                    Title = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Course, global::LightSwitchApplication.Course.DetailsClass, string>.Entry(
                        "Title",
                        global::LightSwitchApplication.Course.DetailsClass.PropertySetProperties._Title_Stub,
                        global::LightSwitchApplication.Course.DetailsClass.PropertySetProperties._Title_ComputeIsReadOnly,
                        global::LightSwitchApplication.Course.DetailsClass.PropertySetProperties._Title_Validate,
                        global::LightSwitchApplication.Course.DetailsClass.PropertySetProperties._Title_GetImplementationValue,
                        global::LightSwitchApplication.Course.DetailsClass.PropertySetProperties._Title_SetImplementationValue,
                        global::LightSwitchApplication.Course.DetailsClass.PropertySetProperties._Title_OnValueChanged);
                private static void _Title_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Course.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Course, global::LightSwitchApplication.Course.DetailsClass, string>.Data> c, global::LightSwitchApplication.Course.DetailsClass d, object sf)
                {
                    c(d, ref d._Title, sf);
                }
                private static bool _Title_ComputeIsReadOnly(global::LightSwitchApplication.Course e)
                {
                    bool result = false;
                    e.Title_IsReadOnly(ref result);
                    return result;
                }
                private static void _Title_Validate(global::LightSwitchApplication.Course e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.Title_Validate(r);
                }
                private static string _Title_GetImplementationValue(global::LightSwitchApplication.Course.DetailsClass d)
                {
                    return d.ImplementationEntity.Title;
                }
                private static void _Title_SetImplementationValue(global::LightSwitchApplication.Course.DetailsClass d, string v)
                {
                    d.ImplementationEntity.Title = v;
                }
                private static void _Title_OnValueChanged(global::LightSwitchApplication.Course e)
                {
                    e.Title_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Course, global::LightSwitchApplication.Course.DetailsClass, string>.Entry
                    Description = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Course, global::LightSwitchApplication.Course.DetailsClass, string>.Entry(
                        "Description",
                        global::LightSwitchApplication.Course.DetailsClass.PropertySetProperties._Description_Stub,
                        global::LightSwitchApplication.Course.DetailsClass.PropertySetProperties._Description_ComputeIsReadOnly,
                        global::LightSwitchApplication.Course.DetailsClass.PropertySetProperties._Description_Validate,
                        global::LightSwitchApplication.Course.DetailsClass.PropertySetProperties._Description_GetImplementationValue,
                        global::LightSwitchApplication.Course.DetailsClass.PropertySetProperties._Description_SetImplementationValue,
                        global::LightSwitchApplication.Course.DetailsClass.PropertySetProperties._Description_OnValueChanged);
                private static void _Description_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Course.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Course, global::LightSwitchApplication.Course.DetailsClass, string>.Data> c, global::LightSwitchApplication.Course.DetailsClass d, object sf)
                {
                    c(d, ref d._Description, sf);
                }
                private static bool _Description_ComputeIsReadOnly(global::LightSwitchApplication.Course e)
                {
                    bool result = false;
                    e.Description_IsReadOnly(ref result);
                    return result;
                }
                private static void _Description_Validate(global::LightSwitchApplication.Course e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.Description_Validate(r);
                }
                private static string _Description_GetImplementationValue(global::LightSwitchApplication.Course.DetailsClass d)
                {
                    return d.ImplementationEntity.Description;
                }
                private static void _Description_SetImplementationValue(global::LightSwitchApplication.Course.DetailsClass d, string v)
                {
                    d.ImplementationEntity.Description = v;
                }
                private static void _Description_OnValueChanged(global::LightSwitchApplication.Course e)
                {
                    e.Description_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Course, global::LightSwitchApplication.Course.DetailsClass, global::LightSwitchApplication.Section>.Entry
                    Sections = new global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Course, global::LightSwitchApplication.Course.DetailsClass, global::LightSwitchApplication.Section>.Entry(
                        "Sections",
                        global::LightSwitchApplication.Course.DetailsClass.PropertySetProperties._Sections_Stub,
                        global::LightSwitchApplication.Course.DetailsClass.PropertySetProperties._Sections_GetReferencedEntities,
                        global::LightSwitchApplication.Course.DetailsClass.PropertySetProperties._Sections_GetEntityCollection);
                private static void _Sections_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Course.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Course, global::LightSwitchApplication.Course.DetailsClass, global::LightSwitchApplication.Section>.Data> c, global::LightSwitchApplication.Course.DetailsClass d, object sf)
                {
                    c(d, ref d._Sections, sf);
                }
                private static global::System.Collections.Generic.IEnumerable<global::LightSwitchApplication.Section> _Sections_GetReferencedEntities(global::LightSwitchApplication.Course.DetailsClass d)
                {
                    return d.GetReferencedEntities<global::LightSwitchApplication.Section, global::LightSwitchApplication.Section.DetailsClass>(global::LightSwitchApplication.Course.DetailsClass.PropertySetProperties.Sections, ref d._Sections);
                }
                private static global::System.Collections.IEnumerable _Sections_GetEntityCollection(global::LightSwitchApplication.Course.DetailsClass d)
                {
                    return d.ImplementationEntity.Sections;
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Course, global::LightSwitchApplication.Course.DetailsClass, global::LightSwitchApplication.CourseCategory>.Entry
                    CourseCategories = new global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Course, global::LightSwitchApplication.Course.DetailsClass, global::LightSwitchApplication.CourseCategory>.Entry(
                        "CourseCategories",
                        global::LightSwitchApplication.Course.DetailsClass.PropertySetProperties._CourseCategories_Stub,
                        global::LightSwitchApplication.Course.DetailsClass.PropertySetProperties._CourseCategories_GetReferencedEntities,
                        global::LightSwitchApplication.Course.DetailsClass.PropertySetProperties._CourseCategories_GetEntityCollection);
                private static void _CourseCategories_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Course.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Course, global::LightSwitchApplication.Course.DetailsClass, global::LightSwitchApplication.CourseCategory>.Data> c, global::LightSwitchApplication.Course.DetailsClass d, object sf)
                {
                    c(d, ref d._CourseCategories, sf);
                }
                private static global::System.Collections.Generic.IEnumerable<global::LightSwitchApplication.CourseCategory> _CourseCategories_GetReferencedEntities(global::LightSwitchApplication.Course.DetailsClass d)
                {
                    return d.GetReferencedEntities<global::LightSwitchApplication.CourseCategory, global::LightSwitchApplication.CourseCategory.DetailsClass>(global::LightSwitchApplication.Course.DetailsClass.PropertySetProperties.CourseCategories, ref d._CourseCategories);
                }
                private static global::System.Collections.IEnumerable _CourseCategories_GetEntityCollection(global::LightSwitchApplication.Course.DetailsClass d)
                {
                    return d.ImplementationEntity.CourseCategories;
                }
    
            }
    
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Course, global::LightSwitchApplication.Course.DetailsClass, int>.Data _Id;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Course, global::LightSwitchApplication.Course.DetailsClass, string>.Data _Title;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Course, global::LightSwitchApplication.Course.DetailsClass, string>.Data _Description;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Course, global::LightSwitchApplication.Course.DetailsClass, global::LightSwitchApplication.Section>.Data _Sections;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Course, global::LightSwitchApplication.Course.DetailsClass, global::LightSwitchApplication.CourseCategory>.Data _CourseCategories;
            
        }
    
        #endregion
    }
    
    #endregion
}
