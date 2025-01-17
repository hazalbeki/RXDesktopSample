﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace GitJenkins
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the GitJenkinsRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("da6c4b2a-4af4-4d28-8ff2-6b9b0a3dd231")]
    public partial class GitJenkinsRepository : RepoGenBaseFolder
    {
        static GitJenkinsRepository instance = new GitJenkinsRepository();
        GitJenkinsRepositoryFolders.AyarlarAppFolder _ayarlar;

        /// <summary>
        /// Gets the singleton class instance representing the GitJenkinsRepository element repository.
        /// </summary>
        [RepositoryFolder("da6c4b2a-4af4-4d28-8ff2-6b9b0a3dd231")]
        public static GitJenkinsRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public GitJenkinsRepository() 
            : base("GitJenkinsRepository", "/", null, 0, false, "da6c4b2a-4af4-4d28-8ff2-6b9b0a3dd231", ".\\RepositoryImages\\GitJenkinsRepositoryda6c4b2a.rximgres")
        {
            _ayarlar = new GitJenkinsRepositoryFolders.AyarlarAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("da6c4b2a-4af4-4d28-8ff2-6b9b0a3dd231")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The Ayarlar folder.
        /// </summary>
        [RepositoryFolder("49363f18-801c-4445-84e5-cf21337e5574")]
        public virtual GitJenkinsRepositoryFolders.AyarlarAppFolder Ayarlar
        {
            get { return _ayarlar; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class GitJenkinsRepositoryFolders
    {
        /// <summary>
        /// The AyarlarAppFolder folder.
        /// </summary>
        [RepositoryFolder("49363f18-801c-4445-84e5-cf21337e5574")]
        public partial class AyarlarAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _aramakutusubirayarbulInfo;
            RepoItemInfo _searchautosuggestboxInfo;
            RepoItemInfo _horizontalthumbInfo;

            /// <summary>
            /// Creates a new Ayarlar  folder.
            /// </summary>
            public AyarlarAppFolder(RepoGenBaseFolder parentFolder) :
                    base("Ayarlar", "/winapp[@packagename='windows.immersivecontrolpanel']", parentFolder, 30000, null, true, "49363f18-801c-4445-84e5-cf21337e5574", "")
            {
                _aramakutusubirayarbulInfo = new RepoItemInfo(this, "AramaKutusuBirAyarBul", "?/?/container[@automationid='SearchAutoSuggestBox']/?/?/text[@name>'Arama kutusu, Bir ayar bu']", ".//text[@name>'Arama kutusu, Bir ayar bu' and @orientation='None' and @iscontentelement='False']", 30000, null, "caeb14f4-0c42-4742-9a54-614f9e2204fa");
                _searchautosuggestboxInfo = new RepoItemInfo(this, "SearchAutoSuggestBox", "?/?/container[@automationid='SearchAutoSuggestBox']", "?/?/container[@automationid='SearchAutoSuggestBox']", 30000, null, "76aace88-81fe-4201-ab7e-846cbfb4455b");
                _horizontalthumbInfo = new RepoItemInfo(this, "HorizontalThumb", ".//container[@name='Çıkış']/slider[@automationid='SystemSettings_Audio_Output_VolumeValue_Slider']/indicator[@automationid='HorizontalThumb']", ".//indicator[@automationid='HorizontalThumb']", 30000, null, "a5ae0672-2642-429a-af3e-01e48357a720");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("49363f18-801c-4445-84e5-cf21337e5574")]
            public virtual Ranorex.WindowsApp Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.WindowsApp>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("49363f18-801c-4445-84e5-cf21337e5574")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The AramaKutusuBirAyarBul item.
            /// </summary>
            [RepositoryItem("caeb14f4-0c42-4742-9a54-614f9e2204fa")]
            public virtual Ranorex.Text AramaKutusuBirAyarBul
            {
                get
                {
                    return _aramakutusubirayarbulInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The AramaKutusuBirAyarBul item info.
            /// </summary>
            [RepositoryItemInfo("caeb14f4-0c42-4742-9a54-614f9e2204fa")]
            public virtual RepoItemInfo AramaKutusuBirAyarBulInfo
            {
                get
                {
                    return _aramakutusubirayarbulInfo;
                }
            }

            /// <summary>
            /// The SearchAutoSuggestBox item.
            /// </summary>
            [RepositoryItem("76aace88-81fe-4201-ab7e-846cbfb4455b")]
            public virtual Ranorex.Container SearchAutoSuggestBox
            {
                get
                {
                    return _searchautosuggestboxInfo.CreateAdapter<Ranorex.Container>(true);
                }
            }

            /// <summary>
            /// The SearchAutoSuggestBox item info.
            /// </summary>
            [RepositoryItemInfo("76aace88-81fe-4201-ab7e-846cbfb4455b")]
            public virtual RepoItemInfo SearchAutoSuggestBoxInfo
            {
                get
                {
                    return _searchautosuggestboxInfo;
                }
            }

            /// <summary>
            /// The HorizontalThumb item.
            /// </summary>
            [RepositoryItem("a5ae0672-2642-429a-af3e-01e48357a720")]
            public virtual Ranorex.Indicator HorizontalThumb
            {
                get
                {
                    return _horizontalthumbInfo.CreateAdapter<Ranorex.Indicator>(true);
                }
            }

            /// <summary>
            /// The HorizontalThumb item info.
            /// </summary>
            [RepositoryItemInfo("a5ae0672-2642-429a-af3e-01e48357a720")]
            public virtual RepoItemInfo HorizontalThumbInfo
            {
                get
                {
                    return _horizontalthumbInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}
