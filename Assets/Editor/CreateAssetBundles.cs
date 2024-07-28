using System.Collections;
using System.IO;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEditor;

public class VrmFrontViewBackdrop
{
	[MenuItem("VrmFrontView/Build AssetBundles")]
	static void BuildAllAssetBundles()
	{
  	string assetBundleDirectory = "Assets/Backdrops";
  	BuildPipeline.BuildAssetBundles(assetBundleDirectory, BuildAssetBundleOptions.None, EditorUserBuildSettings.activeBuildTarget);
	}
}
