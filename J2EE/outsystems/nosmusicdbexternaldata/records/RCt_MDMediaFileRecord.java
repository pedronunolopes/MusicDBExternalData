package outsystems.nosmusicdbexternaldata.records;

import java.io.Serializable;
import java.sql.*;
import java.math.BigDecimal;
import java.util.BitSet;
import org.w3c.dom.*;
import outsystems.objectkeys.*;
import outsystems.runtimecommon.*;
import outsystems.hubedition.runtimeplatform.*;
import outsystems.hubedition.runtimeplatform.db.*;
import outsystems.internal.db.*;
import outsystems.hubedition.databaseabstractionlayer.adoadapters.*;
import outsystems.hubedition.util.*;
import outsystems.hubedition.runtimeplatform.newruntime.*;
import outsystems.nosmusicdbexternaldata.records.*;

import outsystems.nosmusicdbexternaldata.entities.*;
import outsystems.nosmusicdbexternaldata.structures.*;
import outsystems.nosmusicdbexternaldata.recordlists.*;


public class RCt_MDMediaFileRecord implements Serializable, Cloneable, ITypedRecord<RCt_MDMediaFileRecord> {

	private static final GlobalObjectKey Idt_MDMediaFile = GlobalObjectKey.parse("2UmDmepsh0WSfJ_D1JexCA*coeHIal0nNCFW92MI2y0gg");

	public static void ensureInitialized() {}
	public ENt_MDMediaFileEntityRecord ssENt_MDMediaFile;


	/**
	 *
	 * Get Structure instance
	 *
	 * @return  The structure
	 */
	public ENt_MDMediaFileEntityRecord toStructure() {
		return ssENt_MDMediaFile;
	}

	/**
	 *
	 * Constructor
	 *
	 * @param  r
	 *         The base structure
	 */
	public RCt_MDMediaFileRecord(ENt_MDMediaFileEntityRecord r) throws Exception {
		ssENt_MDMediaFile = (ENt_MDMediaFileEntityRecord)
		r.clone();
	}

	public void setChangedAttributes(BitSet value) {
		ssENt_MDMediaFile.ChangedAttributes = value;
	}
	public BitSet getChangedAttributes() {
		return ssENt_MDMediaFile.ChangedAttributes;
	}
	public BitSet OptimizedAttributes;

	/**
	 *
	 * Default Constructor
	 */
	public RCt_MDMediaFileRecord() {
		OptimizedAttributes = null;
		ssENt_MDMediaFile = new ENt_MDMediaFileEntityRecord();
	}

	public BitSet[] getDefaultOptimizedValues() {
		BitSet[] all = new BitSet[1];
		all[0] = BitSetUtils.newInstance(5, false);
		return all;
	}

	public void setAllOptimizedAttributes(BitSet[] value) {
		if (value == null) {
			ssENt_MDMediaFile.OptimizedAttributes = getDefaultOptimizedValues()[0];
		} else {
			ssENt_MDMediaFile.OptimizedAttributes = value[0];
		}
	}
	public BitSet[] getAllOptimizedAttributes() {
		BitSet[] all = new BitSet[1];
		all[0] = ssENt_MDMediaFile.OptimizedAttributes;
		return all;
	}

	/**
	 *
	 * Read a record from database
	 *
	 * @param  r
	 *         Data base reader
	 * @param  index
	 *         index
	 */
	public int read(OSResultSet r, int index) throws ClassCastException {
		index = ssENt_MDMediaFile.read(r, index);
		return index;
	}
	/**
	 *
	 * Read from database
	 *
	 * @param  r
	 *         Data reader
	 */
	public void readDB(OSResultSet r) {
		int index = 0;
		read(r, index);
	}

	/**
	 *
	 * Read from record
	 *
	 * @param  r
	 *         Record
	 */
	public void readIM(RCt_MDMediaFileRecord r) throws Exception {
		this.ssENt_MDMediaFile = (ENt_MDMediaFileEntityRecord) r.ssENt_MDMediaFile.duplicate();
	}


	/**
	 *
	 * Comparison Function
	 *
	 * @param  obj
	 *         Object to compare to.
	 *
	 * @return  True if equal
	 */
	public boolean equals(Object obj) {
		if ((obj == null) || !(obj instanceof RCt_MDMediaFileRecord)) {
			return false;
		}
		RCt_MDMediaFileRecord b = (RCt_MDMediaFileRecord) obj;
		if (!this.ssENt_MDMediaFile.equals(b.ssENt_MDMediaFile)) return false;
		return true;
	}

	/**
	 *
	 * Hash Value Function
	 *
	 * @return  A hash value for the instance
	 */
	public int hashCode() {
		try {
			return super.hashCode() ^ ssENt_MDMediaFile.hashCode();
		} catch (NullPointerException e) {
			return super.hashCode();
		}
	}

	/**
	 *
	 * Performs a Recursive Reset in the instance
	 */
	public void recursiveReset() throws Exception {
		ssENt_MDMediaFile.recursiveReset();
	}

	/**
	 *
	 * Performs a internal Recursive Reset in the instance
	 */
	public void internalRecursiveSave() throws Exception {
		ssENt_MDMediaFile.internalRecursiveSave();
	}

	/**
	 *
	 * Returns a duplicate/clone instance
	 *
	 * @return  Duplicate Instance
	 */
	public RCt_MDMediaFileRecord duplicate() throws Exception {
		RCt_MDMediaFileRecord t = new RCt_MDMediaFileRecord();
		t.ssENt_MDMediaFile = (ENt_MDMediaFileEntityRecord) this.ssENt_MDMediaFile.duplicate();
		t.OptimizedAttributes = null;
		return t;
	}

	public IRecord duplicate$IRecord() throws Exception {
		return duplicate();
	}
	public void toXml(Object parent, Element baseElem, String fieldName, int detailLevel) {
		Element recordElem = VarValue.appendChild(baseElem, "Record");
		if (fieldName != null) {
			VarValue.appendAttribute(recordElem, "debug.field", fieldName);
		}
		if (detailLevel > 0) {
			ssENt_MDMediaFile.toXml(this, recordElem, "t_MDMediaFile", detailLevel - 1);
		} else {
			VarValue.appendDeferredEvaluationElement(recordElem);
		}
	}

	public void evaluateFields(VarValue variable, Object parent, String baseName, String fields) throws java.lang.reflect.InvocationTargetException, IllegalAccessException, IllegalArgumentException {
		String head = VarValue.getHead(fields);
		String tail = VarValue.getTail(fields);
		variable.setFound(false);
		if (head.equals("t_mdmediafile")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".t_MDMediaFile")) variable.setValue(ssENt_MDMediaFile); else variable.setOptimized(true);
			variable.setFieldName("t_mdmediafile");
		}
		if (variable.isFound() && tail != null) variable.evaluateFields(this, head, tail);
	}

	public Object clone() throws CloneNotSupportedException {
		RCt_MDMediaFileRecord t = (RCt_MDMediaFileRecord) super.clone();
		t.ssENt_MDMediaFile = (ENt_MDMediaFileEntityRecord) this.ssENt_MDMediaFile.clone();
		return t;
	}

	public boolean changedAttributeGet(GlobalObjectKey key) throws Exception {
		return ssENt_MDMediaFile.changedAttributeGet(key);
	}

	public boolean optimizedAttributeGet(GlobalObjectKey key) throws Exception {
		return ssENt_MDMediaFile.optimizedAttributeGet(key);
	}

	public Object attributeGet(GlobalObjectKey key) throws Exception {
		if (key.equals(Idt_MDMediaFile)) {
			return ssENt_MDMediaFile;
		} else {
			throw new Exception("Invalid key");
		}
	}
	public void fillFromOther(IRecord other) throws Exception {
		if (other == null) return;
		ssENt_MDMediaFile.fillFromOther((IRecord) other.attributeGet(Idt_MDMediaFile));
	}
}
