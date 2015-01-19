<?xml version="1.0" encoding="utf-8"?>
<serviceModel xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" name="SchedulePublisherServices" generation="1" functional="0" release="0" Id="50b399ab-bade-422c-a4e2-929c4bafb339" dslVersion="1.2.0.0" xmlns="http://schemas.microsoft.com/dsltools/RDSM">
  <groups>
    <group name="SchedulePublisherServicesGroup" generation="1" functional="0" release="0">
      <componentports>
        <inPort name="SchedulePublisherCore:Endpoint1" protocol="http">
          <inToChannel>
            <lBChannelMoniker name="/SchedulePublisherServices/SchedulePublisherServicesGroup/LB:SchedulePublisherCore:Endpoint1" />
          </inToChannel>
        </inPort>
        <inPort name="SchedulePublisherCore:Microsoft.WindowsAzure.Plugins.RemoteForwarder.RdpInput" protocol="tcp">
          <inToChannel>
            <lBChannelMoniker name="/SchedulePublisherServices/SchedulePublisherServicesGroup/LB:SchedulePublisherCore:Microsoft.WindowsAzure.Plugins.RemoteForwarder.RdpInput" />
          </inToChannel>
        </inPort>
      </componentports>
      <settings>
        <aCS name="Certificate|SchedulePublisherCore:Microsoft.WindowsAzure.Plugins.RemoteAccess.PasswordEncryption" defaultValue="">
          <maps>
            <mapMoniker name="/SchedulePublisherServices/SchedulePublisherServicesGroup/MapCertificate|SchedulePublisherCore:Microsoft.WindowsAzure.Plugins.RemoteAccess.PasswordEncryption" />
          </maps>
        </aCS>
        <aCS name="SchedulePublisherCore:CloudToolsDiagnosticAgentVersion" defaultValue="">
          <maps>
            <mapMoniker name="/SchedulePublisherServices/SchedulePublisherServicesGroup/MapSchedulePublisherCore:CloudToolsDiagnosticAgentVersion" />
          </maps>
        </aCS>
        <aCS name="SchedulePublisherCore:Microsoft.WindowsAzure.Plugins.RemoteAccess.AccountEncryptedPassword" defaultValue="">
          <maps>
            <mapMoniker name="/SchedulePublisherServices/SchedulePublisherServicesGroup/MapSchedulePublisherCore:Microsoft.WindowsAzure.Plugins.RemoteAccess.AccountEncryptedPassword" />
          </maps>
        </aCS>
        <aCS name="SchedulePublisherCore:Microsoft.WindowsAzure.Plugins.RemoteAccess.AccountExpiration" defaultValue="">
          <maps>
            <mapMoniker name="/SchedulePublisherServices/SchedulePublisherServicesGroup/MapSchedulePublisherCore:Microsoft.WindowsAzure.Plugins.RemoteAccess.AccountExpiration" />
          </maps>
        </aCS>
        <aCS name="SchedulePublisherCore:Microsoft.WindowsAzure.Plugins.RemoteAccess.AccountUsername" defaultValue="">
          <maps>
            <mapMoniker name="/SchedulePublisherServices/SchedulePublisherServicesGroup/MapSchedulePublisherCore:Microsoft.WindowsAzure.Plugins.RemoteAccess.AccountUsername" />
          </maps>
        </aCS>
        <aCS name="SchedulePublisherCore:Microsoft.WindowsAzure.Plugins.RemoteAccess.Enabled" defaultValue="">
          <maps>
            <mapMoniker name="/SchedulePublisherServices/SchedulePublisherServicesGroup/MapSchedulePublisherCore:Microsoft.WindowsAzure.Plugins.RemoteAccess.Enabled" />
          </maps>
        </aCS>
        <aCS name="SchedulePublisherCore:Microsoft.WindowsAzure.Plugins.RemoteForwarder.Enabled" defaultValue="">
          <maps>
            <mapMoniker name="/SchedulePublisherServices/SchedulePublisherServicesGroup/MapSchedulePublisherCore:Microsoft.WindowsAzure.Plugins.RemoteForwarder.Enabled" />
          </maps>
        </aCS>
        <aCS name="SchedulePublisherCore:Profiling.ProfilingConnectionString" defaultValue="">
          <maps>
            <mapMoniker name="/SchedulePublisherServices/SchedulePublisherServicesGroup/MapSchedulePublisherCore:Profiling.ProfilingConnectionString" />
          </maps>
        </aCS>
        <aCS name="SchedulePublisherCoreInstances" defaultValue="[1,1,1]">
          <maps>
            <mapMoniker name="/SchedulePublisherServices/SchedulePublisherServicesGroup/MapSchedulePublisherCoreInstances" />
          </maps>
        </aCS>
      </settings>
      <channels>
        <lBChannel name="LB:SchedulePublisherCore:Endpoint1">
          <toPorts>
            <inPortMoniker name="/SchedulePublisherServices/SchedulePublisherServicesGroup/SchedulePublisherCore/Endpoint1" />
          </toPorts>
        </lBChannel>
        <lBChannel name="LB:SchedulePublisherCore:Microsoft.WindowsAzure.Plugins.RemoteForwarder.RdpInput">
          <toPorts>
            <inPortMoniker name="/SchedulePublisherServices/SchedulePublisherServicesGroup/SchedulePublisherCore/Microsoft.WindowsAzure.Plugins.RemoteForwarder.RdpInput" />
          </toPorts>
        </lBChannel>
        <sFSwitchChannel name="SW:SchedulePublisherCore:Microsoft.WindowsAzure.Plugins.RemoteAccess.Rdp">
          <toPorts>
            <inPortMoniker name="/SchedulePublisherServices/SchedulePublisherServicesGroup/SchedulePublisherCore/Microsoft.WindowsAzure.Plugins.RemoteAccess.Rdp" />
          </toPorts>
        </sFSwitchChannel>
      </channels>
      <maps>
        <map name="MapCertificate|SchedulePublisherCore:Microsoft.WindowsAzure.Plugins.RemoteAccess.PasswordEncryption" kind="Identity">
          <certificate>
            <certificateMoniker name="/SchedulePublisherServices/SchedulePublisherServicesGroup/SchedulePublisherCore/Microsoft.WindowsAzure.Plugins.RemoteAccess.PasswordEncryption" />
          </certificate>
        </map>
        <map name="MapSchedulePublisherCore:CloudToolsDiagnosticAgentVersion" kind="Identity">
          <setting>
            <aCSMoniker name="/SchedulePublisherServices/SchedulePublisherServicesGroup/SchedulePublisherCore/CloudToolsDiagnosticAgentVersion" />
          </setting>
        </map>
        <map name="MapSchedulePublisherCore:Microsoft.WindowsAzure.Plugins.RemoteAccess.AccountEncryptedPassword" kind="Identity">
          <setting>
            <aCSMoniker name="/SchedulePublisherServices/SchedulePublisherServicesGroup/SchedulePublisherCore/Microsoft.WindowsAzure.Plugins.RemoteAccess.AccountEncryptedPassword" />
          </setting>
        </map>
        <map name="MapSchedulePublisherCore:Microsoft.WindowsAzure.Plugins.RemoteAccess.AccountExpiration" kind="Identity">
          <setting>
            <aCSMoniker name="/SchedulePublisherServices/SchedulePublisherServicesGroup/SchedulePublisherCore/Microsoft.WindowsAzure.Plugins.RemoteAccess.AccountExpiration" />
          </setting>
        </map>
        <map name="MapSchedulePublisherCore:Microsoft.WindowsAzure.Plugins.RemoteAccess.AccountUsername" kind="Identity">
          <setting>
            <aCSMoniker name="/SchedulePublisherServices/SchedulePublisherServicesGroup/SchedulePublisherCore/Microsoft.WindowsAzure.Plugins.RemoteAccess.AccountUsername" />
          </setting>
        </map>
        <map name="MapSchedulePublisherCore:Microsoft.WindowsAzure.Plugins.RemoteAccess.Enabled" kind="Identity">
          <setting>
            <aCSMoniker name="/SchedulePublisherServices/SchedulePublisherServicesGroup/SchedulePublisherCore/Microsoft.WindowsAzure.Plugins.RemoteAccess.Enabled" />
          </setting>
        </map>
        <map name="MapSchedulePublisherCore:Microsoft.WindowsAzure.Plugins.RemoteForwarder.Enabled" kind="Identity">
          <setting>
            <aCSMoniker name="/SchedulePublisherServices/SchedulePublisherServicesGroup/SchedulePublisherCore/Microsoft.WindowsAzure.Plugins.RemoteForwarder.Enabled" />
          </setting>
        </map>
        <map name="MapSchedulePublisherCore:Profiling.ProfilingConnectionString" kind="Identity">
          <setting>
            <aCSMoniker name="/SchedulePublisherServices/SchedulePublisherServicesGroup/SchedulePublisherCore/Profiling.ProfilingConnectionString" />
          </setting>
        </map>
        <map name="MapSchedulePublisherCoreInstances" kind="Identity">
          <setting>
            <sCSPolicyIDMoniker name="/SchedulePublisherServices/SchedulePublisherServicesGroup/SchedulePublisherCoreInstances" />
          </setting>
        </map>
      </maps>
      <components>
        <groupHascomponents>
          <role name="SchedulePublisherCore" generation="1" functional="0" release="0" software="D:\MobileAppDev\SchedulerApp\SchedulerCore\SchedulePublisherServices\SchedulePublisherServices\csx\Release\roles\SchedulePublisherCore" entryPoint="base\x64\WaHostBootstrapper.exe" parameters="base\x64\WaIISHost.exe " memIndex="-1" hostingEnvironment="frontendadmin" hostingEnvironmentVersion="2">
            <componentports>
              <inPort name="Endpoint1" protocol="http" portRanges="80" />
              <inPort name="Microsoft.WindowsAzure.Plugins.RemoteForwarder.RdpInput" protocol="tcp" />
              <inPort name="Microsoft.WindowsAzure.Plugins.RemoteAccess.Rdp" protocol="tcp" portRanges="3389" />
              <outPort name="SchedulePublisherCore:Microsoft.WindowsAzure.Plugins.RemoteAccess.Rdp" protocol="tcp">
                <outToChannel>
                  <sFSwitchChannelMoniker name="/SchedulePublisherServices/SchedulePublisherServicesGroup/SW:SchedulePublisherCore:Microsoft.WindowsAzure.Plugins.RemoteAccess.Rdp" />
                </outToChannel>
              </outPort>
            </componentports>
            <settings>
              <aCS name="CloudToolsDiagnosticAgentVersion" defaultValue="" />
              <aCS name="Microsoft.WindowsAzure.Plugins.RemoteAccess.AccountEncryptedPassword" defaultValue="" />
              <aCS name="Microsoft.WindowsAzure.Plugins.RemoteAccess.AccountExpiration" defaultValue="" />
              <aCS name="Microsoft.WindowsAzure.Plugins.RemoteAccess.AccountUsername" defaultValue="" />
              <aCS name="Microsoft.WindowsAzure.Plugins.RemoteAccess.Enabled" defaultValue="" />
              <aCS name="Microsoft.WindowsAzure.Plugins.RemoteForwarder.Enabled" defaultValue="" />
              <aCS name="Profiling.ProfilingConnectionString" defaultValue="" />
              <aCS name="__ModelData" defaultValue="&lt;m role=&quot;SchedulePublisherCore&quot; xmlns=&quot;urn:azure:m:v1&quot;&gt;&lt;r name=&quot;SchedulePublisherCore&quot;&gt;&lt;e name=&quot;Endpoint1&quot; /&gt;&lt;e name=&quot;Microsoft.WindowsAzure.Plugins.RemoteAccess.Rdp&quot; /&gt;&lt;e name=&quot;Microsoft.WindowsAzure.Plugins.RemoteForwarder.RdpInput&quot; /&gt;&lt;/r&gt;&lt;/m&gt;" />
            </settings>
            <resourcereferences>
              <resourceReference name="DiagnosticStore" defaultAmount="[4096,4096,4096]" defaultSticky="true" kind="Directory" />
              <resourceReference name="EventStore" defaultAmount="[1000,1000,1000]" defaultSticky="false" kind="LogStore" />
            </resourcereferences>
            <storedcertificates>
              <storedCertificate name="Stored0Microsoft.WindowsAzure.Plugins.RemoteAccess.PasswordEncryption" certificateStore="My" certificateLocation="System">
                <certificate>
                  <certificateMoniker name="/SchedulePublisherServices/SchedulePublisherServicesGroup/SchedulePublisherCore/Microsoft.WindowsAzure.Plugins.RemoteAccess.PasswordEncryption" />
                </certificate>
              </storedCertificate>
            </storedcertificates>
            <certificates>
              <certificate name="Microsoft.WindowsAzure.Plugins.RemoteAccess.PasswordEncryption" />
            </certificates>
          </role>
          <sCSPolicy>
            <sCSPolicyIDMoniker name="/SchedulePublisherServices/SchedulePublisherServicesGroup/SchedulePublisherCoreInstances" />
            <sCSPolicyUpdateDomainMoniker name="/SchedulePublisherServices/SchedulePublisherServicesGroup/SchedulePublisherCoreUpgradeDomains" />
            <sCSPolicyFaultDomainMoniker name="/SchedulePublisherServices/SchedulePublisherServicesGroup/SchedulePublisherCoreFaultDomains" />
          </sCSPolicy>
        </groupHascomponents>
      </components>
      <sCSPolicy>
        <sCSPolicyUpdateDomain name="SchedulePublisherCoreUpgradeDomains" defaultPolicy="[5,5,5]" />
        <sCSPolicyFaultDomain name="SchedulePublisherCoreFaultDomains" defaultPolicy="[2,2,2]" />
        <sCSPolicyID name="SchedulePublisherCoreInstances" defaultPolicy="[1,1,1]" />
      </sCSPolicy>
    </group>
  </groups>
  <implements>
    <implementation Id="c4dfabf4-2127-486f-a5d9-5c1518282f97" ref="Microsoft.RedDog.Contract\ServiceContract\SchedulePublisherServicesContract@ServiceDefinition">
      <interfacereferences>
        <interfaceReference Id="e3d27ccb-1b7c-48ba-8c81-1f17e25f9bc7" ref="Microsoft.RedDog.Contract\Interface\SchedulePublisherCore:Endpoint1@ServiceDefinition">
          <inPort>
            <inPortMoniker name="/SchedulePublisherServices/SchedulePublisherServicesGroup/SchedulePublisherCore:Endpoint1" />
          </inPort>
        </interfaceReference>
        <interfaceReference Id="c8177246-1cda-40c4-a3d7-6fe0c3327ea9" ref="Microsoft.RedDog.Contract\Interface\SchedulePublisherCore:Microsoft.WindowsAzure.Plugins.RemoteForwarder.RdpInput@ServiceDefinition">
          <inPort>
            <inPortMoniker name="/SchedulePublisherServices/SchedulePublisherServicesGroup/SchedulePublisherCore:Microsoft.WindowsAzure.Plugins.RemoteForwarder.RdpInput" />
          </inPort>
        </interfaceReference>
      </interfacereferences>
    </implementation>
  </implements>
</serviceModel>